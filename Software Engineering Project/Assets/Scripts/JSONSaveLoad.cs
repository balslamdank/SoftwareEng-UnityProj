using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JSONSaveLoad : MonoBehaviour
{	public InputField campaignName, classLevel, race, backGround, pName, alignment, xPoints;
	public InputField maxHitDice, maxHP, pBonus, inspiration, strength, dexterity, constitution, intelligence, wisdom, charisma;
	public InputField aClass, initiative, speed, cHP, tHP, hitDice, pTraits, ideals, bonds, flaws;
	public InputField name1, name2, name3, abonus1, abonus2, abonus3, damage1, damage2, damage3, rest;
	public InputField pWisdom, otherProf, CP, SP, EP, GP, PP, eqText, featTraits;
	public InputField strengthN, dexN, constN, intN, wisN, charN, acrobatics, anHandling, arcana, athletics, deception;
	public InputField history, insight, intimidation, investigation, medicine, nature, perception, performance, persuasion;
	public InputField religion, sleightHand, stealth, survival;
	public Toggle strengthT, dexT, constT, intT, wisT, charT, acrobaticT, anHandlingT, arcanaT, athleticsT, deceptionT;
	public Toggle historyT, insightT, intimidationT, investigationT, medicineT, natureT, perceptionT, performanceT, persuasionT;
	public Toggle religionT, sleightHandT, stealthT, survivalT;
	public Toggle suc1, suc2, suc3, fail1, fail2, fail3;


	
	


	public string numb;
	

	
	// Save updated data to JSON file
	void Save(string filenumb) 
	{  
		JSONObject charInfo = new JSONObject();
		charInfo.Add("Character Name", campaignName.text);
		charInfo.Add("Class and Level", classLevel.text);
		charInfo.Add("Background", backGround.text);
		charInfo.Add("Player Name", pName.text);
		charInfo.Add("Race", race.text);
		charInfo.Add("Alignment", alignment.text);
		charInfo.Add("Experience Points", xPoints.text);
		charInfo.Add("Strength", strength.text);
		charInfo.Add("Dexterity", dexterity.text);
		charInfo.Add("Constitution", constitution.text);
		charInfo.Add("Intelligence", intelligence.text);
		charInfo.Add("Wisdom", wisdom.text);
		charInfo.Add("Charisma", charisma.text);
		charInfo.Add("Inspiration", inspiration.text);
		charInfo.Add("Proficiency Bonus", pBonus.text);
		charInfo.Add("Strength Saving Throw", strengthN.text);
		charInfo.Add("Dexterity Saving Throw", dexN.text);
		charInfo.Add("Constitution Saving Throw", constN.text);
		charInfo.Add("Intelligence Saving Throw", intN.text);
		charInfo.Add("Wisdom Saving Throw", wisN.text);
		charInfo.Add("Charisma Saving Throw", charN.text);
		charInfo.Add("Acrobatics", acrobatics.text);
		charInfo.Add("Animal Handling", anHandling.text);
		charInfo.Add("Arcana", arcana.text);
		charInfo.Add("Athletics", athletics.text);
		charInfo.Add("Deceptione", deception.text);
		charInfo.Add("History", history.text);
		charInfo.Add("Insight", insight.text);
		charInfo.Add("Intimidation", intimidation.text);
		charInfo.Add("Investigation", investigation.text);
		charInfo.Add("Medicine", medicine.text);
		charInfo.Add("Nature", nature.text);
		charInfo.Add("Perception", perception.text);
		charInfo.Add("Performance", performance.text);
		charInfo.Add("Persuasion", persuasion.text);
		charInfo.Add("Religion", religion.text);
		charInfo.Add("Sleight of Hand", sleightHand.text);
		charInfo.Add("Stealth", stealth.text);
		charInfo.Add("Survival", survival.text);
		charInfo.Add("Passive Perception", pWisdom.text);
		charInfo.Add("Other Proficiencies", otherProf.text);
		charInfo.Add("Armor Class", aClass.text);
		charInfo.Add("initiative", initiative.text);
		charInfo.Add("Speed", speed.text);
		charInfo.Add("Max HP", maxHP.text);
		charInfo.Add("Current HP",cHP.text);
		charInfo.Add("Temporary HP", tHP.text);
		charInfo.Add("Hit Dice", hitDice.text);
		charInfo.Add("Max Hit Dice", maxHitDice.text);
		charInfo.Add("Att/Spell Name 1", name1.text);
		charInfo.Add("Att/Spell Name 2", name2.text);
		charInfo.Add("Att/Sprll Name 3", survival.text);
		charInfo.Add("Atk Bonus 1", abonus1.text);
		charInfo.Add("Atk Bonus 2", abonus2.text);
		charInfo.Add("Atk Bonus 3", abonus3.text);
		charInfo.Add("Damage/Type 1", damage1.text);
		charInfo.Add("Damage/Type 2", damage2.text);
		charInfo.Add("Damage/Type 3", damage3.text);
		charInfo.Add("Additional Attacks", rest.text);
		charInfo.Add("CP", CP.text);
		charInfo.Add("SP", SP.text);
		charInfo.Add("EP", EP.text);
		charInfo.Add("GP", GP.text);
		charInfo.Add("PP", PP.text);
		charInfo.Add("Equipment", eqText.text);
		charInfo.Add("Personality Traits", pTraits.text);
		charInfo.Add("Ideals ", ideals.text);
		charInfo.Add("Bonds", bonds.text);
		charInfo.Add("Flaws", flaws.text);
		charInfo.Add("Equipment", eqText.text);
		charInfo.Add("Features/Traits", featTraits.text);
		charInfo.Add("Strength Toggle", strengthT.isOn);
		charInfo.Add("Dex Toggle", dexT.isOn);
		charInfo.Add("Constitution Toggle", constT.isOn);
		charInfo.Add("Intelligence Toggle", intT.isOn);
		charInfo.Add("Wisdom Toggle", wisT.isOn);
		charInfo.Add("Charisma Toggle", charT.isOn);
		charInfo.Add("Acrobatics Toggle", acrobaticT.isOn);
		charInfo.Add("Animal Handling Toggle", anHandlingT.isOn);
		charInfo.Add("Arcana Toggle", arcanaT.isOn);
		charInfo.Add("Athletics Toggle", athleticsT.isOn);
		charInfo.Add("Deception Toggle", deceptionT.isOn);
		charInfo.Add("History Toggle", historyT.isOn);
		charInfo.Add("Insight Toggle", insightT.isOn);
		charInfo.Add("Intimidation Toggle", intimidationT.isOn);
		charInfo.Add("Investigation Toggle", investigationT.isOn);
		charInfo.Add("Medicine Toggle", medicineT.isOn);
		charInfo.Add("Nature Toggle", natureT.isOn);
		charInfo.Add("Perception Toggle", perceptionT.isOn);
		charInfo.Add("Performance Toggle", performanceT.isOn);
		charInfo.Add("Persuasion Toggle", persuasionT.isOn);
		charInfo.Add("Religion Toggle", religionT.isOn);
		charInfo.Add("Sleight of Hand Toggle", sleightHandT.isOn);
		charInfo.Add("Stealth Toggle", stealthT.isOn);
		charInfo.Add("Survival Toggle", survivalT.isOn);
		charInfo.Add("Success1", suc1.isOn);
		charInfo.Add("Success2", suc2.isOn);
		charInfo.Add("Success3", suc3.isOn);
		charInfo.Add("Failure1", fail1.isOn);
		charInfo.Add("Failure2", fail2.isOn);
		charInfo.Add("Failure3", fail3.isOn);
		
		
		
		
	
		

		

		Debug.Log(charInfo.ToString());

		string path = Application.dataPath + "/PlayerSave" + filenumb + ".json";

		File.WriteAllText(path, charInfo.ToString());
	}

	// Load data to game
	public string readN()
	{
			string pathB = Application.dataPath + "/jsonUtility.json";
			string jsonString = File.ReadAllText(pathB);
			JSONObject charJson = (JSONObject)JSON.Parse(jsonString);
			numb = charJson["ButtonID"];
			return numb;
	}

	void Load(string filenumb)
	{	
		string path = Application.dataPath + "/PlayerSave" + filenumb + ".json";

		string jsonString = File.ReadAllText(path);
		JSONObject charJson = (JSONObject)JSON.Parse(jsonString);

		
		 campaignName.text = 	charJson["Character Name"];
		 classLevel.text = 	charJson["Class and Level"];
		 backGround.text = 	charJson["Background"];
		 pName.text = 	charJson["Player Name"];
		 race.text = 	charJson["Race"];
		 alignment.text = 	charJson["Alignment"];
		 xPoints.text = 	charJson["Experience Points"];
		 strength.text = 	charJson["Strength"];
		 dexterity.text = 	charJson["Dexterity"];
		 constitution.text = 	charJson["Constitution"];
		 intelligence.text = 	charJson["Intelligence"];
		 wisdom.text = 	charJson["Wisdom"];
		 charisma.text = 	charJson["Charisma"];
		 inspiration.text = 	charJson["Inspiration"];
		 pBonus.text = 	charJson["Proficiency Bonus"];
		 strengthN.text = 	charJson["Strength Saving Throw"];
		 dexN.text = 	charJson["Dexterity Saving Throw"];
		 constN.text = 	charJson["Constitution Saving Throw"];
		 intN.text = 	charJson["Intelligence Saving Throw"];
		 wisN.text = 	charJson["Wisdom Saving Throw"];
		 charN.text = 	charJson["Charisma Saving Throw"];
		 acrobatics.text = 	charJson["Acrobatics"];
		 anHandling.text = 	charJson["Animal Handling"];
		 arcana.text = 	charJson["Arcana"];
		 athletics.text = 	charJson["Athletics"];
		 deception.text = 	charJson["Deceptione"];
		 history.text = 	charJson["History"];
		 insight.text = 	charJson["Insight"];
		 intimidation.text = 	charJson["Intimidation"];
		 investigation.text = 	charJson["Investigation"];
		 medicine.text = 	charJson["Medicine"];
		 nature.text = 	charJson["Nature"];
		 perception.text = 	charJson["Perception"];
		 performance.text = 	charJson["Performance"];
		 persuasion.text = 	charJson["Persuasion"];
		 religion.text = 	charJson["Religion"];
		 sleightHand.text = 	charJson["Sleight of Hand"];
		 stealth.text = 	charJson["Stealth"];
		 survival.text = 	charJson["Survival"];
		 pWisdom.text = 	charJson["Passive Perception"];
		 otherProf.text = 	charJson["Other Proficiencies"];
		 aClass.text = 	charJson["Armor Class"];
		 initiative.text = 	charJson["initiative"];
		 speed.text = 	charJson["Speed"];
		 cHP.text = 	charJson["Current HP"];
		 tHP.text = 	charJson["Temporary HP"];
		 maxHP.text =	charJson["Max HP"];
		 hitDice.text = 	charJson["Hit Dice"];
		 maxHitDice.text = charJson["Max Hit Dice"];
		 name1.text = 	charJson["Att/Spell Name 1"];
		 name2.text = 	charJson["Att/Spell Name 2"];
		 survival.text = charJson["Att/Sprll Name 3"];
		 abonus1.text = charJson["Atk Bonus 1"];
		 abonus2.text = 	charJson["Atk Bonus 2"];
		 abonus3.text = 	charJson["Atk Bonus 3"];
		 damage1.text = 	charJson["Damage/Type 1"];
		 damage2.text = 	charJson["Damage/Type 2"];
		 damage3.text = 	charJson["Damage/Type 3"];
		 rest.text = 	charJson["Additional Attacks"];
		 CP.text = 	charJson["CP"];
		 SP.text = 	charJson["SP"];
		 EP.text = 	charJson["EP"];
		 GP.text = 	charJson["GP"];
		 PP.text = 	charJson["PP"];
		 eqText.text = 	charJson["Equipment"];
		 pTraits.text = 	charJson["Personality Traits"];
		 ideals.text = 	charJson["Ideals "];
		 bonds.text = 	charJson["Bonds"];
		 flaws.text = 	charJson["Flaws"];
		 eqText.text = 	charJson["Equipment"];
		 featTraits.text = 	charJson["Features/Traits"];
		 strengthT.isOn = 	charJson["Strength Toggle"];
		 dexT.isOn = 	charJson["Dex Toggle"];
		 constT.isOn = 	charJson["Constitution Toggle"];
		 intT.isOn = 	charJson["Intelligence Toggle"];
		 wisT.isOn = 	charJson["Wisdom Toggle"];
		 charT.isOn = 	charJson["Charisma Toggle"];
		 acrobaticT.isOn = 	charJson["Acrobatics Toggle"];
		 anHandlingT.isOn = 	charJson["Animal Handling Toggle"];
		 arcanaT.isOn = 	charJson["Arcana Toggle"];
		 athleticsT.isOn = 	charJson["Athletics Toggle"];
		 deceptionT.isOn = 	charJson["Deception Toggle"];
		 historyT.isOn = 	charJson["History Toggle"];
		 insightT.isOn = 	charJson["Insight Toggle"];
		 intimidationT.isOn = 	charJson["Intimidation Toggle"];
		 investigationT.isOn = 	charJson["Investigation Toggle"];
		 medicineT.isOn = 	charJson["Medicine Toggle"];
		 natureT.isOn = 	charJson["Nature Toggle"];
		 perceptionT.isOn = 	charJson["Perception Toggle"];
		 performanceT.isOn = 	charJson["Performance Toggle"];
		 persuasionT.isOn = 	charJson["Persuasion Toggle"];
		 religionT.isOn = 	charJson["Religion Toggle"];
		 sleightHandT.isOn = 	charJson["Sleight of Hand Toggle"];
		 stealthT.isOn = 	charJson["Stealth Toggle"];
		 survivalT.isOn = 	charJson["Survival Toggle"];
		 suc1.isOn = 	charJson["Success1"];
		 suc2.isOn = 	charJson["Success2"];
		 suc3.isOn = 	charJson["Success3"];
		 fail1.isOn = 	charJson["Failure1"];
		 fail2.isOn = 	charJson["Failure2"];
		 fail3.isOn = 	charJson["Failure3"];




	}
    // Start is called before the first frame update
    void Start()
    {
		Debug.Log("Path : " + Application.dataPath);

        if(SceneManager.GetActiveScene().name == "CharacterSheet"){
			string numb = readN();
			Load(numb);
		}
    }

	void clearAll()
	
	{
		GameObject[] fieldobjs, toggleobjs; 
		

		fieldobjs = GameObject.FindGameObjectsWithTag("sheetField");

		foreach(GameObject fieldobj in fieldobjs) {
			fieldobj.GetComponent<InputField>().text = ""; }

		toggleobjs = GameObject.FindGameObjectsWithTag("toggleField");
		
		foreach(GameObject toggleobj in toggleobjs) {
		
			toggleobj.GetComponent<Toggle>().isOn = false; }

	
		
	}
    // Update is called once per frame
    public void getSelection(string mySelection)
    {	string selectnumb = readN();
        if(mySelection == "save"){ 
		Save(selectnumb);
		Debug.Log("Working Save");
		}
		if(mySelection == "load"){
		Load(selectnumb);
		Debug.Log("Working Load");}
		if(mySelection == "clear"){
		clearAll();
		}
    }
}
