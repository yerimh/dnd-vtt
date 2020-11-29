using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * TODO: figure out how to deactivate text field with enter
 * TODO: figure out how to not activate text field with space
 */

public class TextManager : MonoBehaviour
{
    public string username;
    public int maxMessages = 25;

    public GameObject chatPanel, textObject;
    public InputField chatBox;

    public Color playerMessage, roll, error;

    [SerializeField]
    List<Message> messageList = new List<Message>();

    // Update is called once per frame
    void Update()
    {
        // If text field isn't empty, send the message to the chat when player presses enter
        if (chatBox.text != "") {
            if (Input.GetKeyDown(KeyCode.Return)) {
                // roll
                if (chatBox.text[0] == '/') {
                    try {
                        if (chatBox.text[1] == 'r') {
                            rollDice();
                        }
                    } catch {
                        SendMessageToChat("Enter a valid number", Message.MessageType.error);
                        chatBox.text = "";
                    }
                }
                // regular message
                else {
                    SendMessageToChat(username + ": " + chatBox.text, Message.MessageType.playerMessage);
                    chatBox.text = "";
                }
            }
        }
        // If text field is empty
        else {
            // If chatbox isn't focused, activate it with enter
            if (!chatBox.isFocused && Input.GetKeyDown(KeyCode.Return)) {
                chatBox.ActivateInputField();
            }
            // Does not work right now
            else if (chatBox.isFocused && chatBox.text == "" && Input.GetKeyDown(KeyCode.Return))
            {
                chatBox.DeactivateInputField();
            }
        }
    }

    public void SendMessageToChat(string text, Message.MessageType messageType)
    {
        if (messageList.Count >= maxMessages)
        {
            Destroy(messageList[0].textObject.gameObject);
            messageList.Remove(messageList[0]);
        }
        Message newMessage = new Message();

        newMessage.text = text;

        GameObject newText = Instantiate(textObject, chatPanel.transform);

        newMessage.textObject = newText.GetComponent<Text>();

        newMessage.textObject.text = newMessage.text;
        newMessage.textObject.color = MessageTypeColor(messageType);

        messageList.Add(newMessage);
    }

    Color MessageTypeColor(Message.MessageType messageType)
    {
        Color color = roll;

        switch(messageType)
        {
            case Message.MessageType.playerMessage:
                color = playerMessage;
                break;

            case Message.MessageType.roll:
                color = roll;
                break;
            case Message.MessageType.error:
                color = error;
                break;
        }

        return color;
    }

    public void rollDice() {
        string[] command = chatBox.text.Split();
        int indexOfD = command[1].IndexOf('d');
        int multiplier;
        if (indexOfD > 1) { // if there's a multiplier
            string multiplierS = chatBox.text.Substring(1,indexOfD - 1);
            multiplier = int.Parse(multiplierS);
        } else {
            multiplier = 1;
        }
        int die = int.Parse(chatBox.text.Substring(indexOfD + 1));
        int random = UnityEngine.Random.Range(1, die);
        string message = username + " rolled a ";
        SendMessageToChat(message + multiplier * random + "!", Message.MessageType.roll);
        chatBox.text = "";
    }
}

[System.Serializable]
public class Message
{
    public string text;
    public Text textObject;
    public MessageType messageType;

    public enum MessageType
    {
        playerMessage,
        roll,
        error
    }
}
