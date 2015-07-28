using System.Media;

namespace SimpleBackup
{
    internal class BackupSound
    {
        private SoundPlayer start_sound = new SoundPlayer(Properties.Resources.start_sound);
        private SoundPlayer press_button = new SoundPlayer(Properties.Resources.prees_button);

        public void startSound()
        {
            start_sound.Play();
        }

        public void pressButton()
        {
            press_button.Play();
        }

    }
}