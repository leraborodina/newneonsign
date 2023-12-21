package com.example.checkthecalculations

import android.content.BroadcastReceiver
import android.content.Context
import android.content.Intent
import android.content.IntentFilter
import android.graphics.Color
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import com.example.checkthecalculations.databinding.ActivityMainBinding
import kotlin.math.roundToInt

class MainActivity : AppCompatActivity() {
    lateinit var binding: ActivityMainBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        binding = ActivityMainBinding.inflate(layoutInflater)
        super.onCreate(savedInstanceState)
        setContentView(binding.root)

        serviceIntent = Intent(applicationContext, Timer::class.java)
        registerReceiver(updateTime, IntentFilter(Timer.TIMER_UPDATED))
    }

    private var timerStarted = false
    private lateinit var serviceIntent: Intent
    private var allTime = 0.0
    private var avgSec = 0.0
    private var maxSec = 0.0
    private var minSec = 99999.0
    private var time = 0.0

    var wins = 0
    var loses = 0
    var allExamples = 0
    var percentage = 0.0
    var choice = true

    fun checkResult(operand:String,operatorOne:Int,operatorTwo:Int, playerResult: Int):Boolean
    {
        var result = 0
        when (operand){
            "+" -> result = operatorOne+operatorTwo
            "-" -> result = operatorOne-operatorTwo
            "*" -> result = operatorOne*operatorTwo
            "/" -> result = operatorOne/operatorTwo
        }
        return (result == playerResult)
    }

    private fun startTimer()
    {
        serviceIntent.putExtra(Timer.TIME_EXTRA, time)
        startService(serviceIntent)
        timerStarted = true
    }

    fun onClickStartBtn(view: View)
    {
        var result = 0
        val operands = arrayOf("+","-","*","/")
        val operand = operands.random()
        var oneOperant = (10..99).random()
        var twoOperator = (10..99).random()
        if (operand == "/")
        {
            while (oneOperant%twoOperator!=0)
            {
                oneOperant = (10..99).random()
                twoOperator = (10..99).random()
            }
        }
        var chance = (1..2).random()
        if (chance == 1)
        {
            choice = true
            when (operand){
                "+" -> result = oneOperant+twoOperator
                "-" -> result = oneOperant-twoOperator
                "*" -> result = oneOperant*twoOperator
                "/" -> result = oneOperant/twoOperator
            }
        }
        else
        {
            choice = false
            result = (-100..100).random()
        }
        binding.FirstOperandTxt.text = oneOperant.toString()
        binding.TwoOperandTxt.text = twoOperator.toString()
        binding.OperationTxt.text = operand
        binding.ResultTxt.text = result.toString()
        binding.WrongBtn.isEnabled = true
        binding.RightBtn.isEnabled = true
        binding.StartBtn.isEnabled = false
        binding.NumberWrongTxt.setBackgroundColor(Color.WHITE)
        binding.NumberRigthTxt.setBackgroundColor(Color.WHITE)
        startTimer()
    }

    fun onClickRightBtn(view: View)
    {
        if (choice)
        {
            wins++
            allExamples++
            binding.NumberRigthTxt.setBackgroundColor(Color.GREEN)
        }
        else
        {
            loses++
            allExamples++
            binding.NumberWrongTxt.setBackgroundColor(Color.RED)
        }
        percentage = (wins/allExamples*100).toDouble()
        binding.NumberRigthTxt.text = wins.toString()
        binding.NumberWrongTxt.text = loses.toString()
        binding.AllExamplesTxt.text = allExamples.toString()
        binding.PercentageCorrectAnswersTxt.text = ("%.2f".format(percentage)).toString()  + "%"
        binding.WrongBtn.isEnabled = false
        binding.RightBtn.isEnabled = false
        binding.StartBtn.isEnabled = true
        resetTimer()
    }

    fun onClickWrongBtn(view: View)
    {
        if (!choice)
        {
            wins++
            allExamples++
            binding.NumberRigthTxt.setBackgroundColor(Color.GREEN)
        }
        else
        {
            loses++
            allExamples++
            binding.NumberWrongTxt.setBackgroundColor(Color.RED)
        }
        percentage = (wins/allExamples*100).toDouble()
        binding.NumberRigthTxt.text = wins.toString()
        binding.NumberWrongTxt.text = loses.toString()
        binding.AllExamplesTxt.text = allExamples.toString()
        binding.PercentageCorrectAnswersTxt.text = ("%.2f".format(percentage)).toString()  + "%"
        binding.WrongBtn.isEnabled = false
        binding.RightBtn.isEnabled = false
        binding.StartBtn.isEnabled = true
        resetTimer()
    }

    private fun resetTimer()
    {
        stopTimer()
        allTime += time
        if (time < minSec) {
            minSec = time
            binding.MinSecTxt.text = time.toString()
        }
        if (time > maxSec) {
            maxSec = time
            binding.MaxSecTxt.text = time.toString()
        }
        avgSec = allTime / allExamples
        binding.AvgSecTxt.text = avgSec.toString()
        time = 0.0
        binding.TimerTxt.text = getTimeStringFromDouble(time)
    }

    private fun stopTimer()
    {
        stopService(serviceIntent)
        timerStarted = false
    }

    private val updateTime: BroadcastReceiver = object : BroadcastReceiver()
    {
        override fun onReceive(context: Context, intent: Intent)
        {
            time = intent.getDoubleExtra(Timer.TIME_EXTRA, 0.0)
            binding.TimerTxt.text = getTimeStringFromDouble(time)
        }
    }

    private fun getTimeStringFromDouble(time: Double): String
    {
        val resultInt = time.roundToInt()
        val seconds = resultInt

        return seconds.toString()
    }
}
