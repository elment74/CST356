<template>
    <div>
        <h2 class ='section-heading'>Persons</h2>
        <table>
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Middle Initial</th>
                    <th>Last Name</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="person in persons" :key="person.id">
                    <td>{{ person.name }}</td>
                    <td>${{ person.price }}</td>
                    <td>{{ person.available ? 'Yes' : 'No' }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    import Vue from 'vue';
    export default {
        name: 'Persons',
        
        data () {
            return {
                persons: []
            }
        },
        methods: {
            getAuthHeader: function() {
                return {
                    headers: {
                        Authorization: 'Bearer ' + this.auth.accessToken
                    }
                }
            },
            getPersons: function() {
                let personsApi = process.env.PERSON_API;
                Vue.axios.get(url, this.getAuthHeader()).then(
                    (response) => {
                        this.persons = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );  
            }
        },
        mounted() {
            this.getPersons();
        }
    }
</script>


<style>
table, th, td{
    border: 1px solid black;
    border-collapse: collapse;
}
th, td{
    padding: 5px;
    text-align: left;
}

.TableHeader{
    background-color: black;
    color:white;
}
</style>
