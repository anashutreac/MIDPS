package mycode.codetranslator;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import static android.icu.lang.UCharacter.toLowerCase;
import static mycode.codetranslator.R.id.editText;

public class MorseCode extends AppCompatActivity
        implements View.OnClickListener {

    EditText inputText;
    TextView outputTextView;
    Button translateButton;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_morse_code);

        inputText = (EditText) findViewById(R.id.editText);
        //String message = inputText.getText().toString();

        translateButton = (Button) findViewById(R.id.button);
        translateButton.setOnClickListener(this);

        outputTextView = (TextView) findViewById(R.id.textView5);
        outputTextView.setText("Translation");

    }

    public void onClick(View v) {

        String message = inputText.getText().toString();
        String messageOutput = new String();
        String temp = new String();

      message = message.toLowerCase();

      //  outputTextView.setText(message + messageOutput);



        for(int i = 0; i < message.length(); i++)
        {
                switch(message.charAt(i))
                {
                    case 'a':
                        temp = (".-/");
                        messageOutput =  messageOutput.concat(temp);

                        break;
                    case 'b':
                        temp = ("-.../");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'c':
                        temp = ("-.-./");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'd':
                        temp = ("-../");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'e':
                        temp = ("./");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'f':
                        temp = ("..-./");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'g':
                        temp = ("--/");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'h':
                        temp = ("..../");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'i':
                        temp = ("../");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'j':
                        temp = (".---/");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'k':
                        temp = ("-.-/");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'l':
                        temp = (".-../");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'm':
                        temp = ("--/");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'n':
                        temp = ("-./");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'o':
                        temp = ("---/");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'p':
                        temp = (".--./");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'q':
                        temp = ("--.-/");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'r':
                        temp = (".-./");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 's':
                        temp = (".../");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 't':
                        temp = ("-/");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'u':
                        temp = ("..-/");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'v':
                        temp = ("...-/");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'w':
                        temp = (".--/");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'x':
                        temp = ("-..-/");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'y':
                        temp = ("-.--/");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    case 'z':
                        temp = ("--../");
                        messageOutput = messageOutput.concat(temp);

                        break;
                    default:
                        temp = ("/");
                        messageOutput = messageOutput.concat(temp);
                        
                }
            }
                 outputTextView.setText(messageOutput);
        }

    }


