function AddClient() {
    var inputs = $('input');
    var model = new Array();
    for (var i = 0; i < inputs.length; i++) {
        var val = inputs[i].value;
        model[i] = val;
    }
    console.log(model);
}