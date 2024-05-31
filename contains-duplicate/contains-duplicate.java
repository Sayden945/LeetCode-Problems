class Solution {
    public boolean containsDuplicate(int[] nums) {
        
    // Replace Type with actual type of your key
    Set<Integer> hashset = new HashSet<Integer>();
    for (Integer key : nums) {
        if (hashset.contains(key)) {
            return true;
        }
        hashset.add(key);
    }
    return false;
}
}
