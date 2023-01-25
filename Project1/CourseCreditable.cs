namespace School{

    public interface ICreditable{
        
        int Credit{ 
            get
            {
                return Credit ;
            }
            set
            {
                if(Credit > 0){
                    Credit= value;
                }
                else{
                    throw new Exception("All courses must be accredited.");
                }
            }
        }
        
    }
}