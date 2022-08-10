using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace MP3_Player
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnForward.Enabled = false;
            btnPrevious.Enabled = false;
            btnPlayPause.Enabled = false;

            //btnDeleteSong.Enabled = false;
            //btnDeleteSong.Enabled = false;
            noOfSongs = list.Count;
            noOfSongstxt.Text = noOfSongs.ToString();
        }
 

        [DllImport("winmm.dll")]
        static extern int mciSendString(string command, StringBuilder buffer, int bufferSize, int hwndCallBack);

        LinkedList list = new LinkedList(); // object name for linkedList
        Form form = new Form();

        string songDirectoryAddress_OFD;
        object song_DirectoryAdrressFromLinkList = null;
        string song_CommandForMci;

        int noOfSongs = 0;
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if (Playlist1.Items.Count == 0)
            {
                btnPrevious.Enabled = false;
                btnForward.Enabled = false;
            }
            else
            {

                btnPrevious.Enabled = true;
                btnForward.Enabled = true;
            }


            OpenFileDialog OFD = new OpenFileDialog();
            OFD.InitialDirectory = "E:";
            DialogResult DR = OFD.ShowDialog();
            if (DR == DialogResult.OK)
            {

                songDirectoryAddress_OFD = OFD.FileName; // file name with path

                //adding into link list
                list.Add(songDirectoryAddress_OFD); // adding song in playlist

                // GETTING ITEM FROM LINK LIST AND DISPLAYING THEM.
                bool check = list.Contains(songDirectoryAddress_OFD);
                if (check == true)
                {
                    int index = list.IndexOf(songDirectoryAddress_OFD);
                    object song_Display = list.Get(index);

                    //playlist.Items.Add(song_Display.ToString());
                    //this.Controls.Add(playlist);

                    Playlist1.Items.Add(song_Display.ToString());
                    noOfSongs = list.Count;
                    noOfSongstxt.Text = noOfSongs.ToString();

                    informationtxt.Text = "Now Double click on an Audio to be played.";
                }

            }
        }




        private void Playlist1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            string selectedSongName = Playlist1.SelectedItems[0].Text.ToString();

            if (string.IsNullOrEmpty(selectedSongName))
            {
                MessageBox.Show("Double click a song to Play.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                bool songCheck = false;
                songCheck = list.Contains(selectedSongName);
                if (songCheck == true)
                {
                    mciSendString("close song", null, 0, 0);
                    //MessageBox.Show(selectedSongName); // this is a check for searched song in link list. working fine.
                    int index = list.IndexOf(selectedSongName);
                    //MessageBox.Show(index.ToString()); // this is a check for index no. in link list. working fine
                    song_DirectoryAdrressFromLinkList = list.Get(index);
                    // MessageBox.Show(song_DirectoryAdrressFromLinkList.ToString()); // this is a check for songAddress from link list. working fine.

                    //DialogResult DR = MessageBox.Show("Selected Song is ready to be Played.\nPress OK.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //if (DR == DialogResult.OK)

                    song_DirectoryAdrressFromLinkList.ToString();

                    song_CommandForMci = "Open \"" + song_DirectoryAdrressFromLinkList + "\" type mpegVideo alias song";

                    mciSendString(song_CommandForMci, null, 0, 0);

                    mciSendString("play song notify", null, 0, 0);
                    btnPlayPause.Enabled = true;


                    //this.Playlist1.SelectedItems[0].Selected = false;
                    //this.Playlist1.Update();

                }
            }
            //mciSendString("close song", null, 0, 0);
        }


        int selCheckForward = 0;
        private void btnForward_Click(object sender, EventArgs e)
        {
            selCheckForward = Playlist1.SelectedItems.Count;

            if (selCheckForward == 0)
            {
                MessageBox.Show("No Song is Played.\nThe player is empty. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string selectedSong = Playlist1.SelectedItems[0].Text.ToString();
                int selectedSongIndex = 0;
                selectedSongIndex = Playlist1.SelectedItems[0].Index; ;
                bool check = list.Contains(selectedSong);
                if (check == true)
                {
                    mciSendString("close song", null, 0, 0);
                    int index = list.IndexOf(selectedSong);
                    index = index + 1;
                    object song = list.Get(index);
                    song.ToString();

                    string mciCommand = "Open \"" + song + "\" type mpegVideo alias song";

                    mciSendString(mciCommand, null, 0, 0);

                    mciSendString("play song", null, 0, 0);

                    Playlist1.SelectedItems[0].Selected = true;
                    this.Playlist1.Update();
                }

                //mciSendString("Close song", null, 0, 0);

                //int selectedIndex = this.Playlist1.SelectedIndices[0];
                selectedSongIndex++;
                // Prevents exception on the last element:      
                if (selectedSongIndex < Playlist1.Items.Count)
                {
                    this.Playlist1.Items[selectedSongIndex].Selected = true;
                    this.Playlist1.Select();
                    this.Playlist1.Items[selectedSongIndex - 1].Selected = false;
                    this.Playlist1.Select();

                    //this.Playlist1.Items[selectedIndex].Focused = true;
                    this.Playlist1.Update();
                }

                else
                {
                    this.Playlist1.SelectedItems[0].Selected = true;
                    this.Playlist1.Select();
                    this.Playlist1.Update();
                    MessageBox.Show("You have reached at the End of your Playlist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }

        int selCheckPrev = 0;
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            selCheckPrev = Playlist1.SelectedItems.Count;

            if (selCheckPrev == 0)
            {
                MessageBox.Show("No Song is Played.\nThe player is empty. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string selectedSong = Playlist1.SelectedItems[0].Text.ToString();
                int selectedSongIndex = 0;
                selectedSongIndex = Playlist1.SelectedItems[0].Index; ;
                bool check = list.Contains(selectedSong);
                if (check == true)
                {
                    mciSendString("close song", null, 0, 0);
                    int index = list.IndexOf(selectedSong);
                    index = index - 1;
                    object song = list.Get(index);
                    song.ToString();

                    string mciCommand = "Open \"" + song + "\" type mpegVideo alias song";

                    mciSendString(mciCommand, null, 0, 0);

                    mciSendString("play song", null, 0, 0);

                    Playlist1.SelectedItems[0].Selected = true;
                    this.Playlist1.Update();
                }

                //mciSendString("Close song", null, 0, 0);

                //int selectedIndex = this.Playlist1.SelectedIndices[0];
                selectedSongIndex--;
                // Prevents exception on the last element:      
                if (selectedSongIndex < Playlist1.Items.Count && selectedSongIndex != -1)
                {
                    this.Playlist1.Items[selectedSongIndex].Selected = true;
                    this.Playlist1.Select();
                    this.Playlist1.Items[selectedSongIndex + 1].Selected = false;
                    this.Playlist1.Select();

                    //this.Playlist1.Items[selectedIndex].Focused = true;
                    this.Playlist1.Update();
                }

                else
                {
                    this.Playlist1.SelectedItems[0].Selected = true;
                    this.Playlist1.Select();
                    this.Playlist1.Update();
                    MessageBox.Show("You Have Reached at the very Begining of your Playlist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }



        int selectionCheckForDel = 0;
        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            selectionCheckForDel = Playlist1.SelectedItems.Count;

            if (selectionCheckForDel == 0)
            {
                MessageBox.Show("For Deletion Please Select a song from your Playlist ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                this.Playlist1.BeginUpdate();

                string selectedSong = Playlist1.SelectedItems[0].Text.ToString();
                bool check = list.Contains(selectedSong);

                if (check == true)
                {

                    mciSendString("close song", null, 0, 0);
                    int index = list.IndexOf(selectedSong);
                    object song = list.Get(index);

                    list.remove(index);
                    Playlist1.Items.Remove(Playlist1.SelectedItems[0]);

                }
                this.Playlist1.EndUpdate();
                this.Playlist1.Refresh();

                noOfSongs = list.Count;
                noOfSongstxt.Text = noOfSongs.ToString();
            }

        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (btnPlayPause.Text.Equals("Pause"))
            {
                mciSendString("pause song", null, 0, 0);
                btnPlayPause.Text = "Play";
            }

            else
            {
                mciSendString("play song", null, 0, 0);
                btnPlayPause.Text = "Pause";
            }


        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            int allSongs = list.Count;
            mciSendString("close song", null, 0, 0);
            int i = 0;
            do
            {
                mciSendString("close songRepeatAll", null, 0, 0);

                object song = list.Get(i);
                song.ToString();
                string songCommand = "Open \"" + song + "\" type mpegVideo alias songRepeatAll";
                mciSendString(songCommand, null, 0, 0);
                mciSendString("play songRepeatAll wait", null, 0, 0);

                i++;
            } while (i < allSongs);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}


       
