namespace PracticeWebAPI.Repository
{
    public class BeautifyCodeRepository : IBeautifyCodeRepository
    {

        public string Beautify(string code, int options)
        {
            while(options > 0)
            {
                int option = options % 10;

                switch (option)
                {
                    case 0: code = rule0(code); break;
                    case 1: code = rule1(code); break;
                    case 2: code = rule2(code); break;
                    case 3: code = rule3(code); break;
                    case 4: code = rule4(code); break;
                    case 5: code = rule5(code); break;
                    case 6: code = rule6(code); break;
                    case 7: code = rule7(code); break;
                    case 8: code = rule8(code); break;
                    case 9: code = rule9(code); break;
                }

                options = options / 10;
            }

            return code;
        }

        public string rule0(string code)
        {
            return code + " from rule 0";
        }

        public string rule1(string code)
        {
            return code + " from rule 1";
        }

        public string rule2(string code)
        {
            return code + " from rule 2";
        }

        public string rule3(string code)
        {
            return code + " from rule 3";
        }

        public string rule4(string code)
        {
            return code + " from rule 4";
        }

        public string rule5(string code)
        {
            return code + " from rule 5";
        }

        public string rule6(string code)
        {
            return code + " from rule 6";
        }

        public string rule7(string code)
        {
            return code + " from rule 7";
        }

        public string rule8(string code)
        {
            return code + " from rule 8";
        }

        public string rule9(string code)
        {
            return code + " from rule 9";
        }
    }
}
