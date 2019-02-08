function initStudents() {
    var data = getStudents();
    displayStudents(data.students);
}

function getStudents() {
    return JSON.parse(studentsData);
}

function displayStudents(students) {

    for(i = 0; i < students.length; i++) {

        console.log('id: ' + students[i].id);
        console.log('email: ' + students[i].email)
        var id = students[i].id;
        var email = students[i].name;
        $("table tbody").append(markup);
    }
}

//text = localStorage.getItem("studentdata");
//obj = JSON.parse(text);
//document.getElementById("").innerHTML = obj.name;
var studentsData = '{"students": [{"id": "452135","email": something@oit.edu},{"name": "recliner","price": 199.00,"available": false}]}'
