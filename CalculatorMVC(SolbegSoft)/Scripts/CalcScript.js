function test() {
    var el = document.getElementById("Example");
    if (this.value === "clear") {
        el.value = "";
    }
    else if (this.value === "calc") Parce(el)
    else el.value += this.value;

}
function Parce(string) {
    string.value.replace(",", ".");
    var operator = string.value.split(/[0-9\,]/)
    var arg = string.value.split(/[\+\-\*\/]/);
    Calculation(arg[0], arg[1], operator)
}
function Calculation(firstNumb, secondNumb, operator) {
    var el = document.getElementById("Example");
    var oper;
    for (var i = 0; i < operator.length; i++) {
        if (operator[i] != "") {
            oper = operator[i];
            break;
        }
        
    }
    switch (oper) {
        case "+":
            el.value = parseFloat(firstNumb) + parseFloat(secondNumb)
            break;
        case "-":
            el.value = firstNumb - secondNumb
            break;
        case "*":
            el.value = firstNumb * secondNumb
            break;
        case "/":
            if (firstNumb === 0) el.value = "На ноль делить нельзя";
            else el.value = parseFloat(firstNumb) / parseFloat(secondNumb)
            break;
    }

}