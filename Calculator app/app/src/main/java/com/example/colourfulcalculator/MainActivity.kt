package com.example.colourfulcalculator

import android.content.res.Resources.Theme
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.ContextThemeWrapper
import android.view.View
import android.widget.Button
import android.widget.TextView
import androidx.constraintlayout.widget.ConstraintLayout
import java.security.PKCS12Attribute


class MainActivity : AppCompatActivity() {

    // Theme changing buttons declaration
    lateinit var redButton: Button
    lateinit var blueButton: Button
    lateinit var yellowButton: Button
    lateinit var greenButton: Button
    lateinit var pinkButton: Button

    // Number buttons declaration
    lateinit var num0: Button
    lateinit var num1: Button
    lateinit var num2: Button
    lateinit var num3: Button
    lateinit var num4: Button
    lateinit var num5: Button
    lateinit var num6: Button
    lateinit var num7: Button
    lateinit var num8: Button
    lateinit var num9: Button

    // Operational buttons declaration
    lateinit var addition: Button
    lateinit var multiplication: Button
    lateinit var subtraction: Button
    lateinit var division: Button

    // Operational bools declaration
    var plusOperator: Boolean = false
    var minusOperator: Boolean = false
    var multiplyOperator: Boolean = false
    var divideOperator: Boolean = false

    lateinit var equals: Button

    lateinit var allclear: Button
    lateinit var clear: Button

    lateinit var result: TextView
    lateinit var calculations: TextView

    var total1: Int = 0
    var total2: Int = 0
    var calculationsnum: Int = 0

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        StyleChanger.onActivityCreateSetTheme(this)
        setContentView(R.layout.activity_main)

        // Initializing theme changing buttons
        redButton = findViewById(R.id.redbutton)
        blueButton = findViewById(R.id.bluebutton)
        yellowButton = findViewById(R.id.yellowbutton)
        greenButton = findViewById(R.id.greenbutton)
        pinkButton = findViewById(R.id.pinkbutton)
        // Initializing Number buttons
        num0 = findViewById(R.id.num_0_button)
        num1 = findViewById(R.id.num_1_button)
        num2 = findViewById(R.id.num_2_button)
        num3 = findViewById(R.id.num_3_button)
        num4 = findViewById(R.id.num_4_button)
        num5 = findViewById(R.id.num_5_button)
        num6 = findViewById(R.id.num_6_button)
        num7 = findViewById(R.id.num_7_button)
        num8 = findViewById(R.id.num_8_button)
        num9 = findViewById(R.id.num_9_button)
        // Initializing Operational buttons
        addition = findViewById(R.id.addition_button)
        multiplication = findViewById(R.id.multiplication_button)
        subtraction = findViewById(R.id.subtraction_button)
        division = findViewById(R.id.division_button)
        equals = findViewById(R.id.equals_button)
        clear = findViewById(R.id.clear_button)
        allclear = findViewById(R.id.allclear_button)
        // Initializing text views
        result = findViewById(R.id.Results)
        calculations = findViewById(R.id.calculations)


        // Adding click listeners to buttons
        redButton.setOnClickListener { StyleChanger.changeTheme(this, StyleChanger.THEME_DEFAULT) }
        blueButton.setOnClickListener { StyleChanger.changeTheme(this, StyleChanger.THEME_BLUE) }
        yellowButton.setOnClickListener {
            StyleChanger.changeTheme(
                this,
                StyleChanger.THEME_YELLOW
            )
        }
        greenButton.setOnClickListener { StyleChanger.changeTheme(this, StyleChanger.THEME_GREEN) }
        pinkButton.setOnClickListener { StyleChanger.changeTheme(this, StyleChanger.THEME_PINK) }

        num0.setOnClickListener { calculations.text = (calculations.text.toString() + "0") }
        num1.setOnClickListener { calculations.text = (calculations.text.toString() + "1") }
        num2.setOnClickListener { calculations.text = (calculations.text.toString() + "2") }
        num3.setOnClickListener { calculations.text = (calculations.text.toString() + "3") }
        num4.setOnClickListener { calculations.text = (calculations.text.toString() + "4") }
        num5.setOnClickListener { calculations.text = (calculations.text.toString() + "5") }
        num6.setOnClickListener { calculations.text = (calculations.text.toString() + "6") }
        num7.setOnClickListener { calculations.text = (calculations.text.toString() + "7") }
        num8.setOnClickListener { calculations.text = (calculations.text.toString() + "8") }
        num9.setOnClickListener { calculations.text = (calculations.text.toString() + "9") }

        // Operational buttons execution
        addition.setOnClickListener { //calculations.text = (calculations.text.toString() + " " + "+" + " ")
            plusOperator = true
            total1 += calculations.text.toString().toInt()
            calculations.setText("")
        }

        multiplication.setOnClickListener { //calculations.text = (calculations.text.toString() + " " + "×" + " ")
            multiplyOperator = true
            total1 += calculations.text.toString().toInt()
            calculations.setText("")
        }

        subtraction.setOnClickListener { //calculations.text = (calculations.text.toString() + " " + "-" + " ")
            minusOperator = true
            total1 += calculations.text.toString().toInt()
            calculations.setText("")
        }

        division.setOnClickListener { //calculations.text = (calculations.text.toString() + " " + "÷" + " ")
            divideOperator = true
            total1 += calculations.text.toString().toInt()
            calculations.setText("")
        }


        clear.setOnClickListener {
            var str: String = calculations.text.toString()
            if (!str.equals("")) {
                str = str.substring(0, str.length - 1)
                calculations.text = str
            }
        }


        allclear.setOnClickListener {
            result.setText("")
            calculations.setText("")
        }


        equals.setOnClickListener {
            if (plusOperator) {
                total2 = total1 + calculations.text.toString().toInt()

                result.setText(total2.toString())

                total1 = 0
            } else if (minusOperator) {
                total2 = total1 - calculations.text.toString().toInt()

                result.setText(total2.toString())

                total1 = 0
            } else if (multiplyOperator) {
                total2 = total1 * calculations.text.toString().toInt()

                result.setText(total2.toString())

                total1 = 0
            } else if (divideOperator) {
                total2 = total1 / calculations.text.toString().toInt()

                result.setText(total2.toString())

                total1 = 0
            }

            result.setText(" " + total2.toString() + " ")
        }
    }
}