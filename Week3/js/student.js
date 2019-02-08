function initStudent() {
    var data = getStudent();
    displayStudent(data.student);
}

function getStudent() {
    return JSON.parse(students);
}

function displayStudent(students) {

    for(i = 0; i < students.length; i++) {
        console.log('id: ' + products[i].id);
        console.log('email: ' + products[i].email);
        var id = students[i].id;
        var email = students[i].email;
        var complete = "<tr><td>" + id + "</td><td>" + email + "</td><td>";
        $("table tbody").append(complete);
    }
}

var students = '{"students": [{"id": "456789","email": something},{"id": "456789","email": something}]}'