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
import Vue from 'vue';
    export default {
        name: 'Students',
        
        data () {
            return {
                students: []
            }
        },
        methods: {
            getStudents: function() {
                let studentsApi = process.env.STUDENT_API;
                Vue.axios.get(url, this.getAuthHeader()).then(
                    (response) => {
                        this.students = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );  
            }
        },
        mounted() {
            this.getStudents();
        }
    }
</script>


<style scoped>

</style>