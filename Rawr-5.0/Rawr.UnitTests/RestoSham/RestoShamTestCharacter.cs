﻿using Rawr.RestoSham;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rawr.UnitTests.RestoSham
{
    internal sealed class RestoShamTestCharacter : Character
    {
        public RestoShamTestCharacter()
        {
            this.Name = "RestoShamTestGuy";
            this.Realm = "TestRealm";
            this.Race = CharacterRace.Tauren;       // needs more cowbell
            this.Class = CharacterClass.Shaman;

            //OpOv: Direct private access of fields is no longer allowed
            PrivateObject po = new PrivateObject(this, new PrivateType(typeof(RestoShamTestCharacter)));
            string p = (string)po.GetField("CurrentModel");
            p = "RestoSham";
            
            //this.CurrentModel = "RestoSham";

            // Use the default options
            CalculationOptionsRestoSham opts = new CalculationOptionsRestoSham();
            this.CalculationOptions = opts;

            // 0/14/57
            // http://www.wowarmory.com/talent-calc.xml?cid=7&tal=00000000000000000000000003050003300000000000000000000050005330335310501122331251
            // CH, Water Mastery, and ES major glyphs
            // Water Shield minor glyph
            this.ShamanTalents = new ShamanTalents("00000000000000000000000003050003300000000000000000000050005330335310501122331251.00000000000100011000000000000");
        }
    }
}
