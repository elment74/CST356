<template>
    <div>
        <h2>Persons</h2>
        <tr>
            <th>First Name</th>
            <th>Middle Initial</th>
            <th>Last Name</th>
        </tr>
        <tr>
            <th>Tung</th>
            <th>H</th>
            <th>Duong</th>
        </tr>
        <tr>
            <th>John</th>
            <th></th>
            <th>Wick</th>
        </tr>
        <tr>
            <th>Keanu</th>
            <th>C</th>
            <th>Reeves</th>
        </tr>
        <tr>
            <th>Harrison</th>
            <th></th>
            <th>Ford</th>
        </tr>
        <tr>
            <th>Takaya</th>
            <th></th>
            <th>Kuroda</th>
        </tr>
    </div>
</template>

<script>
export default {

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
