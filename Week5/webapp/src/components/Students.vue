<template>
    <div>
        <h2 class = 'sectionHeading'>Students</h2>
        <table>
            <thead>
                <tr>
                    <th>id</th>
                    <th>email</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="student in Students" :key="student.id">
                    <td>{{student.id}}</td>
                    <td>{{student.email}}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>


<script>
export default {
    name: 'Students',
    mounted() {
        this.students = getStudent();
    },
    data() {
        return {
            students: []
        }
    }
}

function getStudents() {
    return JSON.parse(testStudents).students;
}

var testStudents = '{"students": [{"id": "123456", "email":"Something@something.com"}]}'
</script>


<style scoped>

</style>