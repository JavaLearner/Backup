using System.Media;

namespace SimpleBackup
{
    internal class BackupSound
    {
        private SoundPlayer start_sound = new SoundPlayer(Properties.Resources.start_sound);
        private SoundPlayer press_button = new SoundPlayer(Properties.Resources.prees_button);
        private SoundPlayer error_sound = new SoundPlayer(Properties.Resources.error_sound);
        private SoundPlayer finish_sound = new SoundPlayer(Properties.Resources.finish_sound);

        public void startSound()
        {
            start_sound.Play();
        }

        public void pressButton()
        {
            press_button.Play();
        }

        public void errorSound()
        {
            error_sound.Play();
        }

        public void finishSound()
        {
            finish_sound.Play();
        }
    }
}