using Commons;
using UnityEngine;

namespace Battles.Consoles
{
    public class BattleConsoleInput : MonoBehaviour
    {
        public BattleConsoleMono mono;

        //==================================================================================================

        public void OnOpen_console()
        {
            var ipf = mono.console_IPF;
            var state = ipf.gameObject.activeSelf;

            var ctx = BattleContext.instance;

            //打开
            if (!state)
            {
                ipf.text = "";
                ipf.Select();
                ipf.ActivateInputField();
                ipf.transform.SetAsLastSibling();
            }
            else //关闭
            {
                var code = ipf.text;
                Console_Code_Helper.try_do_code(code, typeof(BattleConsoleCode));
            }

            ipf.gameObject.SetActive(!state);
            ctx.is_ban_player_input = !state;
        }


        public void OnDelete_console()
        {
            var ipf = mono.console_IPF;
            var state = ipf.gameObject.activeSelf;
            if (!state) return;

            ipf.text = "";
        }
    }
}

