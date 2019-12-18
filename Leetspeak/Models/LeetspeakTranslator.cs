using MainProgram;
namespace Changer
{
    public class LeetspeakTranslator
    {
        public string Translate(string input)
        {
            char[] array = input.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] == 's'|| array[i]=='S') && !(i == 0 || array[i-1] == ' ' || array[i-1] == '\"' || array[i-1] == '\''))
                {
                    if (array[i] == 's')
                        array[i] = 'z';
                    else
                        array[i] = 'Z';
                }
                    
                switch (array[i])
                {
                    case 'e':
                        array[i] = '3';
                        break;
                    case 'E':
                        array[i] = '3';
                        break;
                    case 'o':
                        array[i] = '0';
                        break;
                    case 'O':
                        array[i] = '0';
                        break;
                    case 'I':
                        array[i] = '1';
                        break;
                    case 't':
                        array[i] = '7';
                        break;
                    case 'T':
                        array[i] = '7';
                        break;
                    default:
                        break;
                }
            }
            return string.Join("", array);;
        }
    }
}