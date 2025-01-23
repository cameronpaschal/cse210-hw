class Job {


    public String _company;
    public String _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job() {
        
    }


    public void Display(){
        String displayMessage = _jobTitle + " (" + _company + ") " + _startYear + "-" + _endYear;
        Console.WriteLine(displayMessage);
    }

}