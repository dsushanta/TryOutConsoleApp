using System;
using System.Collections.Generic;
using System.Text;

namespace TryOutConsoleApp
{
    class Tutorial
    {
        int tutorialId;
        string tutorialName;

        public Tutorial() {
        }
        public Tutorial(int tutorialId, string tutorialName) {
            this.tutorialId = tutorialId;
            this.tutorialName = tutorialName;
        }
        
        public int tutorialIdProperty
        {
            get
            {
                return tutorialId;
            }
            set
            {
                tutorialId = value;
            }
        }

        public string tutorialNameProperty
        {
            get
            {
                return tutorialName;
            }
            set
            {
                tutorialName = value;
            }
        }

        public override string ToString() {
            return tutorialId + " : " + tutorialName;
        }
    }
}
