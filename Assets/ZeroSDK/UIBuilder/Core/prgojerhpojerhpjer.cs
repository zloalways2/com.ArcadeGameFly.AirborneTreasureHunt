using System;
using UnityEngine;
using ZeroSDK.GameCore.Manager;
using ZeroSDK.UIBuilder.Config;
using ZeroSDK.UIBuilder.Core.UIElements;


namespace ZeroSDK.UIBuilder.Core
{
    public class prgojerhpojerhpjer : ewrfegbfhng<prgojerhpojerhpjer>
    {
        [SerializeField] private Camera uiCamera;
        [SerializeField] private werfgtfbhgn werfgtfbhgn;
        [SerializeField] private erwregtrfbhn config;
        [SerializeField] private rereherherherh[] screens;

        public Camera UICamera => uiCamera;
        public werfgtfbhgn Effects => werfgtfbhgn;
        public erwregtrfbhn Config => config;

        public override void ewregtrfhng()
        {
            var weregtrhn = screens.Length;
            for (var i = 0; i < weregtrhn; i++)
            {
                var ewregtrhgn = screens[i];
                ewregtrhgn.wqerfegtrhytn();

                ewregtrhgn.orgpjrehpojrehpero();

                if (ewregtrhgn.ShowOnInit)
                {
                    ewregtrhgn.oprgjerpojreopgj();
                }
            }
        }

        public rereherherherh esrgtrhygjh(Type type, bool isSolo = true, bool startCallback = true, bool endCallback = true)
        {
            var ewrgehtr = default(rereherherherh);
            var rwgrethrn = screens.Length;
            for (var i = 0; i < rwgrethrn; i++)
            {
                var ewtegthrgfnh = screens[i];
                if (ewtegthrgfnh.Ignore) continue;

                if (ewrgehtr == null && ewtegthrgfnh.GetType() == type)
                {
                    ewrgehtr = ewtegthrgfnh;
                    ewtegthrgfnh.wqeregtrhytng(startCallback, endCallback);
                }
                else
                {
                    if (isSolo)
                    {
                        ewtegthrgfnh.qewregtrhnt(startCallback, endCallback);
                    }
                }
            }

            return ewrgehtr;
        }


        public T ewtregthrg<T>(bool isSolo = true, bool startCallback = true, bool endCallback = true) where T : rereherherherh
        {
            // Debug.Log(typeof(T));
            var rewegtrh = default(rereherherherh);
            var wegrehtnr = screens.Length;
            for (var i = 0; i < wegrehtnr; i++)
            {
                var wgrehtnr = screens[i];
                if (wgrehtnr.Ignore) continue;

                if (rewegtrh == null && wgrehtnr is T)
                {
                    rewegtrh = wgrehtnr;
                    wgrehtnr.wqeregtrhytng(startCallback, endCallback);
                }
                else
                {
                    if (isSolo)
                    {
                        wgrehtnr.qewregtrhnt(startCallback, endCallback);
                    }
                }
            }

            return rewegtrh as T;
        }


        public T nhfgbdfv<T>(bool isSolo = true, bool startCallback = true, bool endCallback = true)
            where T : rereherherherh
        {
            // Debug.Log(typeof(T));
            var werreghrgn = default(rereherherherh);
            var wrgreth = screens.Length;
            for (var i = 0; i < wrgreth; i++)
            {
                var wregthgfnh = screens[i];
                if (wregthgfnh.Ignore) continue;

                if (werreghrgn == null && wregthgfnh is T)
                {
                    werreghrgn = wregthgfnh;
                    wregthgfnh.oprgjerpojreopgj(startCallback, endCallback);
                }
                else
                {
                    if (isSolo)
                    {
                        wregthgfnh.orgpjrehpojrehpero(startCallback, endCallback);
                    }
                }
            }

            return werreghrgn as T;
        }


        public T qwtrethrn<T>(bool startCallback = true, bool endCallback = true) where T : rereherherherh
        {
            var ewrgethrn = default(rereherherherh);
            var wreeghg = screens.Length;
            for (var i = 0; i < wreeghg; i++)
            {
                var wreegthrn = screens[i];
                if (wreegthrn.Ignore) continue;
                if (ewrgethrn == null && wreegthrn is T)
                {
                    ewrgethrn = wreegthrn;
                    wreegthrn.qewregtrhnt(startCallback, endCallback);
                }
            }

            return ewrgethrn as T;
        }


        public T rwetgrhng<T>(bool startCallback = true, bool endCallback = true) where T : rereherherherh
        {
            var wreegtrhn = default(rereherherherh);
            var wtreghtr = screens.Length;
            for (var i = 0; i < wtreghtr; i++)
            {
                var qewetgrhyt = screens[i];
                if (qewetgrhyt.Ignore) continue;
                if (wreegtrhn == null && qewetgrhyt is T)
                {
                    wreegtrhn = qewetgrhyt;
                    qewetgrhyt.orgpjrehpojrehpero(startCallback, endCallback);
                }
            }

            return wreegtrhn as T;
        }


        public T rjhjoerhjerpohj<T>()
        {
            var weregtrhnh = screens.Length;
            for (var i = 0; i < weregtrhnh; i++)
            {
                var ujtyhgfdv = screens[i];
                if (ujtyhgfdv is T w)
                {
                    return w;
                }
            }

            return default;
        }
    }
}