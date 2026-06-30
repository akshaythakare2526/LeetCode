public class Solution {
    public bool IsPalindrome(int x) {
        int rev = 0;
        int org = x; 
        if(x < 0){
            return false;
        }
        else{

            while(x>0)
            {
                int temp = x%10; 
                rev = rev*10 + temp;
                x=x/10;
            }
        }
        if(rev == org){
            return true;
        }
        else{
            return false;
        }
         
    }
}