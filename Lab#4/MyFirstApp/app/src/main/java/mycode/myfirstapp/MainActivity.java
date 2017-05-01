package mycode.myfirstapp;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.content.Intent;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;


public class MainActivity extends AppCompatActivity
        implements View.OnClickListener {

    EditText inputText;
    TextView outputTextView;
    Button translateButton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        inputText = (EditText) findViewById(R.id.editText);
        String message = inputText.getText().toString();

        translateButton = (Button) findViewById(R.id.button);
        translateButton.setOnClickListener(this);

        outputTextView = (TextView) findViewById(R.id.textView2);
        outputTextView.setText("Translation");

    }
    public void onClick(View v){

        outputTextView.setText(inputText.getText().toString()
                + " is learning Android development!");

        outputTextView.setText(inputText.getText().toString()
                + " is learning Android development!");

        //String message = inputText.getText().toString();
        //outputTextView.setText(inputText.getText().toString().length());

        //String translateMessage;
//        message.toLowerCase();
//        for(int i = 0; i < message.length(); i++)
//        {
//            while(true)
//            {
//                switch(message.charAt(i))
//                {
//                    case 'a':
//                        outputTextView.setText(".-/");
//                        break;
//                    case 'b':
//                        outputTextView.setText("-.../");
//                        break;
//                    case 'c':
//                        outputTextView.setText("-.-./");
//                        break;
//                    case 'd':
//                        outputTextView.setText("-../");
//                        break;
//                    case 'e':
//                        outputTextView.setText("./");
//                        break;
//                    case 'f':
//                        outputTextView.setText("..-./");
//                        break;
//                    case 'g':
//                        outputTextView.setText("--/");
//                        break;
//                    case 'h':
//                        outputTextView.setText("..../");
//                        break;
//                    case 'i':
//                        outputTextView.setText("../");
//                        break;
//                    case 'j':
//                        outputTextView.setText(".---/");
//                        break;
//                    case 'k':
//                        outputTextView.setText("-.-/");
//                        break;
//                    case 'l':
//                        outputTextView.setText(".-../");
//                        break;
//                    case 'm':
//                        outputTextView.setText("--/");
//                        break;
//                    case 'n':
//                        outputTextView.setText("-./");
//                        break;
//                    case 'o':
//                        outputTextView.setText("---/");
//                        break;
//                    case 'p':
//                        outputTextView.setText(".--./");
//                        break;
//                    case 'q':
//                        outputTextView.setText("--.-/");
//                        break;
//                    case 'r':
//                        outputTextView.setText(".-./");
//                        break;
//                    case 's':
//                        outputTextView.setText(".../");
//                        break;
//                    case 't':
//                        outputTextView.setText("-/");
//                        break;
//                    case 'u':
//                        outputTextView.setText("..-/");
//                        break;
//                    case 'v':
//                        outputTextView.setText("...-/");
//                        break;
//                    case 'w':
//                        outputTextView.setText(".--/");
//                        break;
//                    case 'x':
//                        outputTextView.setText("-..-/");
//                        break;
//                    case 'y':
//                        outputTextView.setText("-.--/");
//                        break;
//                    case 'z':
//                        outputTextView.setText("--../");
//                        break;
//                    default:
//                        outputTextView.setText("/");
//                }
//            }
//        }
//        outputTextView.setText(inputText.getText().toString()
//                + " is learning Android development!");
    }
    }

}
