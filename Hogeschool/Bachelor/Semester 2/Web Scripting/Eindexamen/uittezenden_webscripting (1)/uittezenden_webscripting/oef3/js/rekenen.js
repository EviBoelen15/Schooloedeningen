// naam: Evi Boelen 1TINH

// hint: if( ! /^\d+$/.test(ingave) )

window.addEventListener("load", handleLoad);


function handleLoad () {
	let button_start_rekenen = document.getElementById("button_start_rekenen");
	button_start_rekenen.addEventListener("click",handleClick );
}


function handleClick () {
	/*document.getElementById('button_start_rekenen').onclick = function() {
		if (typeof document.getElementById('input_aantal') != 'number') {

		}
	}*/
	if (isNaN(document.getElementById("input_aantal").value)) {
		let paragraph = document.getElementById("p");
		let text = document.createTextNode("Dit is geen nummer");

		paragraph.appendChild(text);
		console.log("Dit is geen nummer")
	} else {
		let maxOef = document.getElementById("input_aantal").value;
		for (let index = 0; index < maxOef; index++) {
			//toevoegen hr element
			var x = document.createElement("HR");
			document.body.appendChild(x);

			//aanmaken randoms
			let getal1=parseInt(10*Math.random());
			let getal2=parseInt(10*Math.random());

			// toevoegen div
			var newDiv = document.createElement("div");
			newDiv.innerHTML= getal1 + " * " + getal2 + " = ";
			document.body.appendChild(newDiv);

			//toevoegen textvak
			var y = document.createElement("INPUT");
			y.setAttribute("type", "text");
			y.setAttribute("id", "special_text");
			document.body.appendChild(y);
		}
	}
}
function handleKeyupInput(event){
	if (isNaN(document.getElementById("special_text").value)) {
		event.target.fontcolor("red");
	}
}

