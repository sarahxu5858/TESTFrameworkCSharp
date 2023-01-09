global using NUnit.Framework;
using OpenQA.Selenium.DevTools.V106.DOM;

class mytest
{
    public char returnaunique(string s)
    {


        var word = new Dictionary<char, int>();
        foreach (char l in s)
        {
            if (word.ContainsKey(l))
            {
                word[l] += 1;
            }
            else
            {
                word[l] = 1;
            }
        }
        foreach (char l in s)
        {
            if (word[l] == 1)
            {
                return l;
            }

        }

        throw new Exception("not a string");

    }
    [Test]
    public void test1()
    {
        string a = "googgggggooooogggle";
        char t = returnaunique(a);
        Console.WriteLine(t);
        Assert.AreEqual('l', t);
    }

}