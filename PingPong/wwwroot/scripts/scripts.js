
var halIndex = 0;
function halNumbers() {
  var speed = 900;
  if (halIndex < halOutputArray.length) {
    document.getElementById("halOutput").innerHTML += "<li>" + halOutputArray[halIndex] + "</li>";
    halIndex++;
    setTimeout(halNumbers, speed);
  }
}


$(function() {

var typeIndex = 0; //Not sure why this needs to be outside of the function.
function typeWriter() {
  var txt = "Good morining HAL. I need to run a diagnotic check on you. Once you're ready I'll input the test number. ";
  var speed = 50;

  if (typeIndex < txt.length) {
    document.getElementById("daveSays").innerHTML += txt.charAt(typeIndex);
    typeIndex++;
    setTimeout(typeWriter, speed);
    $("#userNumber").delay(6500).fadeIn("swing");
    $("#numberButton").delay(7500).fadeIn("swing");
    }
  }
  setTimeout(typeWriter, 900);
})
