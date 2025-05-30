using System;
class MainClass
{
    public static string StringChallenge(string str)
    {
        
        
        for (int i = 0;i < str.Length; i++)
        {
            
            char Char = str[i];
            string Str_num = Convert.ToString(Char);
            int num = Convert.ToInt32(Str_num);
            int status = 1;

            for (int j = i + 1; j <= i + num - 1 && j < str.Length; j++)
            {
                if (str[i] != str[j])
                {
                    
                    break;
                }
                else
                {
                   status+=1;
                    if (status == num)
                    {
                        return "true";
                    }

                }

            }
        }



        return "false";
    }
}