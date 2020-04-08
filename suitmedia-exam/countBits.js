/**
 * created by : risyandi @2020
 * this is a exam for the selection or recruit new employee
 */

function countBits(num, bitNum) {
    let binary = Number(num).toString(2);
    let temp = "";
    let result = null;

    for (let index = 0; index < binary.length; index++) {
        let binNum = binary[index];
        if (binNum == bitNum) {
            temp += binNum;
        } else if (binNum > 2) {
            return null;
        }
    }

    result = parseInt(temp.length);
    console.log(result);
    return result;
}

countBits(13, 1);