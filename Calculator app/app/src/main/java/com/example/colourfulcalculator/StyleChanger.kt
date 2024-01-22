package com.example.colourfulcalculator

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity

object StyleChanger {
        private var calTheme: Int = 0
        const val THEME_DEFAULT = 0
        const val THEME_BLUE = 1
        const val THEME_YELLOW = 2
        const val THEME_GREEN = 3
        const val THEME_PINK = 4


        fun changeTheme(activity: AppCompatActivity, theme: Int) {
            calTheme = theme
            activity.finish()
            activity.startActivity(Intent(activity, activity::class.java))
        }

        fun onActivityCreateSetTheme(activity: AppCompatActivity) {
            when (calTheme) {
                THEME_DEFAULT -> activity.setTheme(R.style.RedTheme)
                THEME_BLUE -> activity.setTheme(R.style.BlueTheme)
                THEME_YELLOW -> activity.setTheme(R.style.YellowTheme)
                THEME_GREEN -> activity.setTheme(R.style.GreenTheme)
                THEME_PINK -> activity.setTheme(R.style.PinkTheme)
            }
        }
}