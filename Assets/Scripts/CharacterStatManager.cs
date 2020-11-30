using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterStatManager : MonoBehaviour
{
    private bool state = false;
    [SerializeField] Button profile;
    [SerializeField] Canvas characterSheet;
    [SerializeField] TMP_InputField charNameInput, playerNameInput;
    public string charName, playerName;
    [SerializeField] TMP_InputField levelInput;
    public int level;
    [SerializeField] TMP_InputField classInput, raceInput, bgInput, alignInput;
    public string charClass, race, background, alignment;
    [SerializeField] TMP_InputField saveDCInput;
    public int saveDC;
    [SerializeField] TMP_InputField attBonusInput;
    public int attackBonus;
    [SerializeField] TMP_InputField ACInput, initInput, speedInput;
    public int armorClass, initiative, speed;
    [SerializeField] TMP_InputField profInput, passivePercInput, inspoInput;
    public int proficiency, passivePerception, inspiration;
    [SerializeField] TMP_InputField healthInput;
    public int health;
    [SerializeField] TMP_InputField hitDieInput;
    public string hitDie;
    [SerializeField] TMP_InputField strInput, strModInput, strSaveInput;
    public int strength, strMod, strSave;
    [SerializeField] TMP_InputField dexInput, dexModInput, dexSaveInput;
    public int dexterity, dexMod, dexSave;
    [SerializeField] TMP_InputField conInput, conModInput, conSaveInput;
    public int constitution, conMod, conSave;
    [SerializeField] TMP_InputField intInput, intModInput, intSaveInput;
    public int intelligence, intMod, intSave;
    [SerializeField] TMP_InputField wisInput, wisModInput, wisSaveInput;
    public int wisdom, wisMod, wisSave;
    [SerializeField] TMP_InputField chaInput, chaModInput, chaSaveInput;
    public int charisma, chaMod, chaSave;
    [SerializeField] TMP_InputField acrInput, animHandInput, arcInput, athInput, decInput, histInput, insInput, intimInput, invInput, medInput, natInput, percInput, perfInput, persInput, relInput, SOHInput, stealthInput, survInput;
    public int acrobatics, animalHandling, arcana, athletics, deception, history, insight, intimidation, investigation, medicine, nature, perception, performance, persuasion, religion, sleightOfHand, stealth, survival;

    // Start is called before the first frame update
    void Start()
    {
        // Button profileBtn = profile.GetComponent<Button>();
        profile.onClick.AddListener(toggleCharacterSheet);
    }

    // Update is called once per frame
    void Update()
    {
        updateStats();
    }

    public void updateStats() {
        charName = charNameInput.text;
        playerName = playerNameInput.text;
        if (!int.TryParse(levelInput.text, out level)) level = 0;
        charClass = classInput.text;
        race = raceInput.text;
        background = bgInput.text;
        alignment = alignInput.text;
        if (!int.TryParse(strInput.text, out strength)) strength = 0;
        // if (!int.TryParse(strModInput.text, out strMod)) strMod = 0;
        // if (!int.TryParse(strSaveInput.text, out strSave)) strSave = 0;

        if (!int.TryParse(dexInput.text, out dexterity)) dexterity = 0;
        // if (!int.TryParse(dexModInput.text, out dexMod)) dexMod = 0;
        // if (!int.TryParse(dexSaveInput.text, out dexSave)) dexSave = 0;

        if (!int.TryParse(conInput.text, out constitution)) constitution = 0;
        // if (!int.TryParse(conModInput.text, out conMod)) conMod = 0;
        // if (!int.TryParse(conSaveInput.text, out conSave)) conSave = 0;

        if (!int.TryParse(intInput.text, out intelligence)) intelligence = 0;
        // if (!int.TryParse(intModInput.text, out intMod)) intMod = 0;
        // if (!int.TryParse(intSaveInput.text, out intSave)) intSave = 0;

        if (!int.TryParse(wisInput.text, out wisdom)) wisdom = 0;
        // if (!int.TryParse(wisModInput.text, out wisMod)) wisMod = 0;
        // if (!int.TryParse(wisSaveInput.text, out wisSave)) wisSave = 0;

        if (!int.TryParse(chaInput.text, out charisma)) charisma = 0;
        // if (!int.TryParse(chaModInput.text, out chaMod)) chaMod = 0;
        // if (!int.TryParse(chaSaveInput.text, out chaSave)) chaSave = 0;

        if (!int.TryParse(ACInput.text, out armorClass)) armorClass = 0;
        if (!int.TryParse(initInput.text, out initiative)) initiative = 0;
        if (!int.TryParse(speedInput.text, out speed)) speed = 0;
        if (!int.TryParse(profInput.text, out proficiency)) proficiency = 0;
        if (!int.TryParse(passivePercInput.text, out passivePerception)) passivePerception = 0;
        if (!int.TryParse(inspoInput.text, out inspiration)) inspiration = 0;
        if (!int.TryParse(healthInput.text, out health)) health = 0;
        hitDie = hitDieInput.text;
        if (!int.TryParse(saveDCInput.text, out saveDC)) saveDC = 0;
        if (!int.TryParse(attBonusInput.text, out attackBonus)) attackBonus = 0;

        // if (!int.TryParse(acrInput.text, out acrobatics)) acrobatics = 0;
        // if (!int.TryParse(animHandInput.text, out animalHandling)) animalHandling = 0;
        // if (!int.TryParse(arcInput.text, out arcana)) arcana = 0;
        // if (!int.TryParse(athInput.text, out athletics)) athletics = 0;
        // if (!int.TryParse(decInput.text, out deception)) deception = 0;
        // if (!int.TryParse(histInput.text, out history)) history = 0;
        // if (!int.TryParse(insInput.text, out insight)) insight = 0;
        // if (!int.TryParse(intimInput.text, out intimidation)) intimidation = 0;
        // if (!int.TryParse(invInput.text, out investigation)) investigation = 0;
        // if (!int.TryParse(medInput.text, out medicine)) medicine = 0;
        // if (!int.TryParse(natInput.text, out nature)) nature = 0;
        // if (!int.TryParse(percInput.text, out perception)) perception = 0;
        // if (!int.TryParse(perfInput.text, out performance)) performance = 0;
        // if (!int.TryParse(persInput.text, out persuasion)) persuasion = 0;
        // if (!int.TryParse(relInput.text, out religion)) religion = 0;
        // if (!int.TryParse(SOHInput.text, out sleightOfHand)) sleightOfHand = 0;
        // if (!int.TryParse(stealthInput.text, out stealth)) stealth = 0;
        // if (!int.TryParse(survInput.text, out survival)) survival = 0;
    }

    public void toggleCharacterSheet() {
        if (state) {
            state = false;
        } else {
            state = true;
        }
        characterSheet.gameObject.SetActive(state);
    }
}
