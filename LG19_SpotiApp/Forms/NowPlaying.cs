using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyAPI.Local;
using SpotifyAPI.Local.Models;
using SpotifyAPI.Local.Enums;

namespace LG19_SpotiApp
{

    public partial class NowPlaying : LCDForm
    {
        public static SpotifyLocalAPI _spotify;

        public NowPlaying()
        {
            InitializeComponent();
        }

        private void setEvents()
        {
            _spotify.OnTrackTimeChange += _OnTrackTimeChange;
            _spotify.OnTrackChange += _OnTrackChange;
            _spotify.SynchronizingObject = this;
            _spotify.OnPlayStateChange += _OnPlayStateChange;
        }

        private void NowPlaying_Load(object sender, EventArgs e)
        {

            LCDForm._activeForm = this;

            if (SpotifyLocalAPI.IsSpotifyRunning())
            {
                if (SpotifyLocalAPI.IsSpotifyWebHelperRunning())
                {
                    _spotify = new SpotifyLocalAPI();
                    setEvents();
                    if (_spotify.Connect())
                    {

                        StatusResponse status = _spotify.GetStatus();

                        if (status.Playing)
                        {
                            btn_play.BackgroundImage = Properties.Resources.pause;
                        }
                        else
                        {
                            btn_play.BackgroundImage = Properties.Resources.play;
                        }


                        SetForm(status.Track);

                        progressBar1.Value = (int)status.PlayingPosition;
                        LabelTimeIs.Text = FormatTime(status.PlayingPosition);

                        _spotify.ListenForEvents = true;
                    }
                }
            }
        }

        private void SetForm(Track Track)
        {
            LabelTrackTitle.Text = Track.TrackResource.Name;
            LabelTrackAlbum.Text = Track.AlbumResource.Name;
            LabelTrackArtist.Text = Track.ArtistResource.Name;
            pictureBox1.Image = Track.GetAlbumArt(AlbumArtSize.Size160);

            progressBar1.Maximum = Track.Length;
            LabelTimeMax.Text = FormatTime(Track.Length);
        }

        private void _OnTrackTimeChange(object sender, TrackTimeChangeEventArgs e)
        {
            
            progressBar1.Value = (int)e.TrackTime;
            LabelTimeIs.Text = FormatTime(e.TrackTime);
        }

        private void _OnTrackChange(object sender, TrackChangeEventArgs e)
        {
            SetForm(e.NewTrack);
        }

        private void _OnPlayStateChange(object sender, PlayStateEventArgs e)
        {
            if (e.Playing)
            {
                btn_play.BackgroundImage = Properties.Resources.pause;
            } else {
                btn_play.BackgroundImage = Properties.Resources.play;
            }
        }

        private static String FormatTime(double sec)
        {
            TimeSpan span = TimeSpan.FromSeconds(sec);
            String secs = span.Seconds.ToString(), mins = span.Minutes.ToString();
            if (secs.Length < 2)
                secs = "0" + secs;
            return mins + ":" + secs;
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            _spotify.Previous();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            StatusResponse status = _spotify.GetStatus();
            if (status.Playing)
            {
                _spotify.Pause();
            }
            else
            {
                _spotify.Play();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            _spotify.Skip();
        }

        public override void OnLCDButtonPress(uint Button)
        {
            var test = Button;
        }

    }
}
