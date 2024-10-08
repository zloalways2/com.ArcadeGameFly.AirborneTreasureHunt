using System;
using System.Collections.Generic;
using UnityEngine;
using ZeroSDK.UIBuilder.AddOns.Button;
using ZeroSDK.UIBuilder.Core;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class ewrehtrythrgewgrehtr : rereherherherh
    {
        [SerializeField] private rewgrehtrn exitButton;
        [SerializeField] private List<rewgrehtrn> levelButtons;

        public event Action eprjherhpjo
        {
            add => exitButton.oerherh += value;
            remove => exitButton.oerherh += value;
        }

        public event Action<int> hreherh;

        protected override void ewrgehtrnthgew()
        {
            for (int i = 0; i < levelButtons.Count; i++)
            {
                var id = i;
                levelButtons[i].oerherh += () => hreherh?.Invoke(id);
            }
        }

        public void gwegwgewgwegew(int levelsCount)
        {
            for (int i = 0; i < Mathf.Min(levelsCount+1, levelButtons.Count); i++)
            {
                var fadeValue = i < levelsCount+1 ? 1 : 0.16f;
                levelButtons[i].CG.alpha = fadeValue;
            }
        }
        
        protected override void pijerhpjrehperjh() => prgojerhpojerhpjer.ewregtrh.rjhjoerhjerpohj<rgpoejrrhojerhj>().reherherherhe();
    }
}