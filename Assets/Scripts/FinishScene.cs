using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FinishScene : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField] 
    TextMeshProUGUI Text;

    [SerializeField] 
    TextMeshProUGUI buttonText;

    void Start(){

        int isCongrats = PlayerPrefs.GetInt("IsCongrats", 0);
        string finishTime = PlayerPrefs.GetString("FinishTime", " ");


        if(isCongrats == 1){

            Text.text = "Congratulations!" + " You've finished at\n " + finishTime;
            buttonText.text = "Another Level";
            


        } else {

            Text.text = "Try Again!" + " You've finished at\n  " + finishTime;
            buttonText.text = "Try Again";
        }

    }

    public void SameLevel(){
        string testType = PlayerPrefs.GetString("TestType", " ");
        if(testType == "A" && buttonText.text == "Another Level" ){
  
            SceneManager.LoadScene("SampleSceneB");
             PlayerPrefs.DeleteAll();
                    
        }else if(testType == "A" && buttonText.text == "Try Again" ){

            SceneManager.LoadScene("SampleScene");
            PlayerPrefs.DeleteKey("FinishTime");
            PlayerPrefs.DeleteKey("IsCongrats");

        }else if(testType == "B" && buttonText.text == "Try Again" ){
        
            SceneManager.LoadScene("SampleSceneB");
            PlayerPrefs.DeleteKey("FinishTime");
            PlayerPrefs.DeleteKey("IsCongrats");


        }
        else{
            SceneManager.LoadScene("SampleScene");
             PlayerPrefs.DeleteAll();
        }


    }

    public void BackToMainMenu (){
        SceneManager.LoadScene("MainMenu");
        PlayerPrefs.DeleteAll();
    }


 

}
