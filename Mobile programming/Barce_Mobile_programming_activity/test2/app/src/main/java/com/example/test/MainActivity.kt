package com.example.test

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.Toast

class MainActivity : AppCompatActivity() {
    var a = "a"
    var b = "b"
    var c = "c"
    var stack =""
    var sum = 0

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val buttonadd = findViewById<Button>(R.id.button7)
        buttonadd.setOnClickListener {



                val buttona = findViewById<Button>(R.id.button)
                buttona.setOnClickListener {
                    stack += a
                    Toast.makeText(applicationContext, stack, Toast.LENGTH_LONG).show()

                }
                val buttonb = findViewById<Button>(R.id.button2)
                buttonb.setOnClickListener {
                    stack += b
                    Toast.makeText(applicationContext, stack, Toast.LENGTH_LONG).show()

                }
                val buttonc = findViewById<Button>(R.id.button3)
                buttonc.setOnClickListener {
                    stack += c
                    Toast.makeText(applicationContext, stack, Toast.LENGTH_LONG).show()

                }
                val button4 = findViewById<Button>(R.id.button4)
                button4.setOnClickListener {
                    sum = sum + 1
                    Toast.makeText(applicationContext, sum.toString(), Toast.LENGTH_LONG).show()

                }
                val button5 = findViewById<Button>(R.id.button5)
                button5.setOnClickListener {
                    sum = sum + 2
                    Toast.makeText(applicationContext, sum.toString(), Toast.LENGTH_LONG).show()

                }
                val button6 = findViewById<Button>(R.id.button6)
                button6.setOnClickListener {
                    sum = sum + 3
                    Toast.makeText(applicationContext, sum.toString(), Toast.LENGTH_LONG).show()

                }

        }
        val buttonsub = findViewById<Button>(R.id.button8)
        buttonsub.setOnClickListener{
            if(stack == "") {
                Toast.makeText(applicationContext, "no letter", Toast.LENGTH_LONG).show()
            }



                val buttona = findViewById<Button>(R.id.button)
                buttona.setOnClickListener {
                    stack = stack.dropLast(1)
                    Toast.makeText(applicationContext, stack, Toast.LENGTH_LONG).show()

                }
                val buttonb = findViewById<Button>(R.id.button2)
                buttonb.setOnClickListener {
                    stack = stack.dropLast(1)
                    Toast.makeText(applicationContext, stack, Toast.LENGTH_LONG).show()

                }
                val buttonc = findViewById<Button>(R.id.button3)
                buttonc.setOnClickListener {
                    stack = stack.dropLast(1)
                    Toast.makeText(applicationContext, stack, Toast.LENGTH_LONG).show()

                }
                val button4 = findViewById<Button>(R.id.button4)
                button4.setOnClickListener {
                    var checker = sum - 1
                    if(checker<0){
                        sum = 0
                        Toast.makeText(applicationContext, "cannot subtract", Toast.LENGTH_LONG).show()
                        return@setOnClickListener
                    }

                    sum = checker
                    Toast.makeText(applicationContext, sum.toString(), Toast.LENGTH_LONG).show()


                }
                val button5 = findViewById<Button>(R.id.button5)
                button5.setOnClickListener {
                    var checker = sum - 2
                    if(checker<0){
                        sum = 0
                        Toast.makeText(applicationContext, "cannot subtract", Toast.LENGTH_LONG).show()
                        return@setOnClickListener
                    }
                    sum = checker
                    Toast.makeText(applicationContext, sum.toString(), Toast.LENGTH_LONG).show()

                }
                val button6 = findViewById<Button>(R.id.button6)
                button6.setOnClickListener {
                    var checker = sum -3
                    if(checker<0){
                        sum = 0
                        Toast.makeText(applicationContext, "cannot subtract", Toast.LENGTH_LONG).show()
                        return@setOnClickListener
                    }
                    sum = checker
                    Toast.makeText(applicationContext, sum.toString(), Toast.LENGTH_LONG).show()

                }

}

        }

    }
