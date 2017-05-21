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

    }
    }

