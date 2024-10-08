using UnityEngine;
using ZeroSDK.Utility.Singleton;

namespace _project.Scripts
{
    public sealed class gerherhrehreh : gerherhreherh<gerherhrehreh>
    {
        [SerializeField] private AudioSource musicSource;
        [SerializeField] private AudioSource pressSource;

        public override void Awake()
        {
            base.Awake();
            rerherherherh(PlayerPrefs.GetFloat("Music", 1));
            hnghgrewergetgrn(PlayerPrefs.GetFloat("Effects", 1));
        }

        public void rerherherherh(float v)
        {
            musicSource.volume = v;
        }

        public void hnghgrewergetgrn(float v)
        {
            pressSource.volume = v;
        }

        public override void OnDestroy()
        {
            PlayerPrefs.SetFloat("Music", musicSource.volume);
            PlayerPrefs.SetFloat("Effects", pressSource.volume);

            PlayerPrefs.Save();
        }

        public void erwegtrhnge() => pressSource.Play();
    }
}