/**
 * created by : risyandi @2020
 * this is a exam for the selection or recruit new employee
 */

function theSaurusWord(word) {
    let wordsSaurus = {
        "big": ["large", "great", "huge", "fat"],
        "huge": ["enourmous", "gigantic"]
    };

    if (word == "big") {
        console.log(wordsSaurus.big);
    } else if (word == "huge") {
        console.log(wordsSaurus.huge);
    } else {
        console.log(null);
    }

}

theSaurusWord("big");