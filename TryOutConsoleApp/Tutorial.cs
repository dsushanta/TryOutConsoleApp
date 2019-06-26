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
        public int getTutorialId() {
            return tutorialId;
        }
        public string getTutorialName(string name) {
            return tutorialName;
        }
        public void setTutorialId(int id) {
            tutorialId = id;
        }
        public void setTutorialName(string name) {
            tutorialName = name;
        }
        public override string ToString() {
            return tutorialId + " : " + tutorialName;
        }
    }
}
