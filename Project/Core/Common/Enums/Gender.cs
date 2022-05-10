using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Core.Common.Enums
{
    public enum Gender
    {
        None = 0,
        [Description("https://i.imgur.com/8qkUzs5.png")][Display(Name = "Male")] Male = 1,
        [Description("https://i.imgur.com/jyXPJ1I.png")][Display(Name = "Female")] Female = 2,
        [Description("https://i.imgur.com/cOPiSa5.png")][Display(Name = "Gender questioning")] GenderQuestioning = 3,
        [Description("https://i.imgur.com/yEqZ3BZ.png")][Display(Name = "Apache helicopter")] ApacheHelicopter = 4,
        [Description("https://i.imgur.com/hk76Ste.png")][Display(Name = "Non-binary mocha frapuccino")] NonbinaryMochaFrapuccino = 5,
        [Description("https://i.imgur.com/8FxFWNd.png")][Display(Name = "No gender only rage")] NoGenderOnlyRage = 6,
        [Description("https://i.imgur.com/4yTP8Mp.png")][Display(Name = "Mayonnaise")] Mayonnaise = 7,
        [Description("https://i.imgur.com/piO6E1A.png")][Display(Name = "Bipolar junction transistor")] BipolarJunctionTransistor = 8,
        [Description("https://i.imgur.com/q3VItFg.png")][Display(Name = "Chaos undivided")] ChaosUndivided = 9,
        [Description("https://i.imgur.com/rzuAJRn.png")][Display(Name = "Gender fluid: third gender and demi-girl")] GenderFluidThirdGenderAndDemigirl = 10,
        [Description("https://i.imgur.com/cG5pf3K.png")][Display(Name = "Bigender: third gender and demi-boy")] BigenderThirdGenderAndDemiboy = 11,
        [Description("https://i.imgur.com/R7OerQh.png")][Display(Name = "Will of fire")] WillOfFire = 12,
        [Description("https://i.imgur.com/3AkCcuT.png")][Display(Name = "Uranus")] Uranus = 13,
        [Description("https://i.imgur.com/KCZVagL.png")][Display(Name = "Between 1-3 knots southward")] Between1And3KnotsSouthward = 14,
        [Description("https://i.imgur.com/UOCeFV2.png")][Display(Name = "Hellboy")] Hellboy = 15,
        [Description("https://i.imgur.com/Zj0Ll41.png")][Display(Name = "Demigod")] Demigod = 16,
        [Description("https://i.imgur.com/ODvnhGt.png")][Display(Name = "Assassin")] Assassin = 17,
        [Description("https://i.imgur.com/5aajru7.png")][Display(Name = "Rate of gender fluidity")] RateOfGenderFluidity = 18,
        [Description("https://i.imgur.com/A0IrYxw.png")][Display(Name = "a Turn off")] ATurnOff = 19
    }
}