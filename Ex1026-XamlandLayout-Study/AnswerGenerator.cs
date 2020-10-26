using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1026_XamlandLayout_Study
{
    class AnswerGenerator
    {
        string[] answers = new string[]{
    "동두는 바보얌","동두는 배안고파!!","동두는 배고파 ㅜㅜ",
    "동두는 배고파서 지금 집갈고야","동두는 카페에서 먹을거 사먹을거야",
            "동두는 자격증공부 다하고 집갈고야",
    "동두는 배고파서 공부를 못하겠어 ㅜㅜ"
};

        public string GetRandomAnswer(string question)
        {

            Random rnd = new Random();

            return answers[rnd.Next(0, answers.Length)];
        }
    }
}
