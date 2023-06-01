public class Solution {
    public int RomanToInt(string s) {
        
        int result = 0; //Intiliaze 0
        
        //Hashmap to store keys & values
        IDictionary<char, int> rValues = new Dictionary<char, int>(); 
            rValues.Add('I', 1);
            rValues.Add('V', 5);
            rValues.Add('X', 10);
            rValues.Add('L', 50);
            rValues.Add('C', 100);
            rValues.Add('D', 500);
            rValues.Add('M', 1000);
        
        //For each character get value of key
        for(int i = 0; i < s.Length - 1; i++)
        {
            //If the value preceding the next roman numeral is smaller, then minus value
            //else add value on
            if(rValues[s[i]] < rValues[s[i + 1]])
            {
                result -= rValues[s[i]];
            }
            else {
                result += rValues [s[i]];
            }
        }
        //Add last value to result
        result += rValues[s[s.Length-1]];
        
        return result;
    }
}