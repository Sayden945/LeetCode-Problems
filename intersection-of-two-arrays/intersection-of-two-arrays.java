class Solution {
    public int[] intersection(int[] nums1, int[] nums2) {
            
        Set<Integer> hashset = new HashSet<Integer>();
        Set<Integer> intersect = new HashSet<Integer>();
        
        for(Integer key : nums1){
            hashset.add(key);
        }
        for(Integer key : nums2){
            if(hashset.contains(key)){
                intersect.add(key);
            }
        }
        int[] result = new int[intersect.size()];
        int i = 0;
        for (Integer num : intersect) {
            result[i++] = num;
        }
        return result;
    }
}