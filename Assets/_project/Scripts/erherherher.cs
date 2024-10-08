using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using ZeroSDK.UIBuilder.AddOns.Button;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class erherherher : rereherherherh
    {
        [SerializeField] private RectTransform skyshipNavigator;
        [SerializeField] private TextMeshProUGUI cosmicScoreDisplay;
        [SerializeField] private RectTransform aetherCollectiblePrefab;
        [SerializeField] private RectTransform celestialPlayspace;
        [SerializeField] private Slider etherealTimekeeper;
        [SerializeField] private RectTransform leftDimensionalGate;
        [SerializeField] private RectTransform rightDimensionalGate;
        [SerializeField] private TextMeshProUGUI cosmicScoreDisplay2;
        [SerializeField] private rewgrehtrn menuButton;
        [SerializeField] private rewgrehtrn menu2Button;
        [SerializeField] private kiujyhtgrfedw gameView;
        [SerializeField] private kiujyhtgrfedw winView;

        private readonly List<RectTransform> hnrnrtnrge = new List<RectTransform>();
        private CancellationTokenSource erojgrepgj;
        private float gojrger = 500f;
        private float pgjoregpjerg = 400f;
        private int rgrekgerojger;
        private bool opgjetrgpoerjg;
        private bool gjergjergoreg;
        private ewgwegwegewgw gohergehrge;

        public event Action hrttrhrt;

        public event Action wrehtrnhrgew;

        public event Action<ewgwegwegewgw> ewregthryrgref;

        private void Awake()
        {
            menuButton.oerherh += () => hrttrhrt?.Invoke();
            menu2Button.oerherh += () => wrehtrnhrgew?.Invoke();
            
            wrgerogiherjgioreihig();
        }

        private void wrgerogiherjgioreihig()
        {
            rgojeirgjerpgerjgperjger();
        }

        private void rgojeirgjerpgerjgperjger()
        {
            var ewewgwe = leftDimensionalGate.gameObject.AddComponent<Button>();
            var rnijnrt = leftDimensionalGate.gameObject.AddComponent<EventTrigger>();

            var herpojerhpo = new EventTrigger.Entry {eventID = EventTriggerType.PointerDown};
            herpojerhpo.callback.AddListener((_) => opgjetrgpoerjg = true);
            rnijnrt.triggers.Add(herpojerhpo);

            var grjpojgrepoegrjo = new EventTrigger.Entry {eventID = EventTriggerType.PointerUp};
            grjpojgrepoegrjo.callback.AddListener((_) => opgjetrgpoerjg = false);
            rnijnrt.triggers.Add(grjpojgrepoegrjo);

            var rgjpogerjegrjorejop = rightDimensionalGate.gameObject.AddComponent<Button>();
            var erpojerpojerh = rightDimensionalGate.gameObject.AddComponent<EventTrigger>();

            var pogrjergojpo = new EventTrigger.Entry {eventID = EventTriggerType.PointerDown};
            pogrjergojpo.callback.AddListener((_) => gjergjergoreg = true);
            erpojerpojerh.triggers.Add(pogrjergojpo);

            var gjregjerphejrhpo = new EventTrigger.Entry {eventID = EventTriggerType.PointerUp};
            gjregjerphejrhpo.callback.AddListener((_) => gjergjergoreg = false);
            erpojerpojerh.triggers.Add(gjregjerphejrhpo);

            reojerhreojherjh(leftDimensionalGate);
            reojerhreojherjh(rightDimensionalGate);
        }

        private void reojerhreojherjh(RectTransform portal)
        {
            var image = portal.gameObject.AddComponent<Image>();
            image.color = new Color(0, 0, 0, 0);
        }


        public void eperojherphjerhp()
        {
            regjregoerjpherohroejhperjoh();
        }

        public async UniTaskVoid gorjoergjergpjerg(ewgwegwegewgw lvlgwegwegweg)
        {
            gohergehrge = lvlgwegwegweg;
            erojgrepgj?.Cancel();
            erojgrepgj = new CancellationTokenSource();

            gameView.oprgjerpojreopgj();
            winView.orgpjrehpojrehpero();
            
            rgrekgerojger = 0;
            ijhrehjerherijh();

            float rgerghe = 0;
            float oprgjreopj = 0;
            float rogpeerjohpherjop = 2f;

            etherealTimekeeper.value = 1;

            while (!erojgrepgj.Token.IsCancellationRequested)
            {
                await UniTask.Yield();
                rgerghe += Time.deltaTime;
                oprgjreopj += Time.deltaTime;
                etherealTimekeeper.value = 1f - (rgerghe / 30f);

                if (rgerghe >= 30f)
                {
                    ewregthryrgref?.Invoke(gohergehrge);
                    regjregoerjpherohroejhperjoh();
                    
                    gameView.orgpjrehpojrehpero();
                    winView.oprgjerpojreopgj();
                    return;
                }

                if (oprgjreopj < rogpeerjohpherjop)
                    continue;
                oprgjreopj = 0;

                wpegjoergprjegperjgrepogj();
            }
        }

        private void wpegjoergprjegperjgrepogj()
        {
            var celestialPosition = new Vector2(
                UnityEngine.Random.Range(-celestialPlayspace.rect.width / 2 + 75, celestialPlayspace.rect.width / 2 - 75),
                celestialPlayspace.rect.height + 10f
            );

            var aetherialForm = Instantiate(aetherCollectiblePrefab, celestialPlayspace);
            aetherialForm.anchoredPosition = celestialPosition;
            hnrnrtnrge.Add(aetherialForm);
        }

        private void Update()
        {
            ropgjerpgojreg();
            lrgekrpogerjhprej();
            pewogjfwepfojewfopwje();
        }

        private void ropgjerpgojreg()
        {
            var pogjergpojergjpo = skyshipNavigator.anchoredPosition;

            if (opgjetrgpoerjg)
            {
                pogjergpojergjpo.x -= pgjoregpjerg * Time.deltaTime;
            }

            if (gjergjergoreg)
            {
                pogjergpojergjpo.x += pgjoregpjerg * Time.deltaTime;
            }

            pogjergpojergjpo.x = Mathf.Clamp(pogjergpojergjpo.x, -celestialPlayspace.rect.width / 2 + 40, celestialPlayspace.rect.width / 2 - 40);
            skyshipNavigator.anchoredPosition = pogjergpojergjpo;

            float ophjerhpojerhopjerh = 0f;
            if (opgjetrgpoerjg) ophjerhpojerhopjerh = 15f;
            if (gjergjergoreg) ophjerhpojerhopjerh = -15f;

            skyshipNavigator.rotation = Quaternion.Lerp(
                skyshipNavigator.rotation,
                Quaternion.Euler(0, 0, ophjerhpojerhopjerh),
                Time.deltaTime * 10f
            );
        }

        private void lrgekrpogerjhprej()
        {
            for (int i = hnrnrtnrge.Count - 1; i >= 0; i--)
            {
                if (!hnrnrtnrge[i]) continue;

                if (Vector3.Distance(hnrnrtnrge[i].transform.position, skyshipNavigator.transform.position) < 1f)
                {
                    Destroy(hnrnrtnrge[i].gameObject);
                    hnrnrtnrge.RemoveAt(i);
                    rgrekgerojger += 100;
                    ijhrehjerherijh();
                }
            }
        }

        private void pewogjfwepfojewfopwje()
        {
            for (int i = hnrnrtnrge.Count - 1; i >= 0; i--)
            {
                if (!hnrnrtnrge[i]) continue;

                var hehrhpejrhperohjerh = hnrnrtnrge[i].anchoredPosition;
                hehrhpejrhperohjerh.y -= gojrger * Time.deltaTime;
                hnrnrtnrge[i].anchoredPosition = hehrhpejrhperohjerh;

                if (hehrhpejrhperohjerh.y < -celestialPlayspace.rect.height / 2 - 20)
                {
                    Destroy(hnrnrtnrge[i].gameObject);
                    hnrnrtnrge.RemoveAt(i);
                }
            }
        }

        private void ijhrehjerherijh()
        {
            cosmicScoreDisplay.text = $"Score: {rgrekgerojger}";
            cosmicScoreDisplay2.text = $"Score: {rgrekgerojger}";
        }

        private void regjregoerjpherohroejhperjoh()
        {
            erojgrepgj?.Cancel();
            foreach (var aether in hnrnrtnrge)
            {
                if (aether) Destroy(aether.gameObject);
            }

            hnrnrtnrge.Clear();
        }

        private void OnDestroy()
        {
            erojgrepgj?.Cancel();
        }
    }
}