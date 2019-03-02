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
                <tr v-for="product in products" :key="product.id">
                    <td>{{ product.name }}</td>
                    <td>${{ product.price }}</td>
                    <td>{{ product.available ? 'Yes' : 'No' }}</td>
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
            getPersons: function() {
                let personsApi = process.env.PERSON_API;
                Vue.axios.get(personsApi).then(
                    (response) => {
                        console.log(response)
                        this.products = response.data;
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
