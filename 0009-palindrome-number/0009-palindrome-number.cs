public class Solution {
    public bool IsPalindrome(int x) {
        string arr = x.ToString();   //Parse int to string
        int length = arr.Length - 1;
        for(int i = 0;  i < length-i; i++) 
        {
            if(arr[i] != arr[length-i]) //Compare reversed string
            {
                return false;
            }
        }
        return true;
    }
}