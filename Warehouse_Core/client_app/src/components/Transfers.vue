<template>
  <div class="transfers">
    <p>{{title}}</p>

        <!-- Details  -->

             <p>
      <router-link to="/createtransfer">{{ option1 }}</router-link>
    </p>

    <p>
      <router-link to="/listtransfers">{{ option2 }}</router-link>
    </p>

    <p>
      <router-link to="/updatetransfer">{{ option3 }}</router-link>
    </p>

    <p>
      <router-link to="/deletetransfer">{{ option4 }}</router-link>
    </p>
    
    <router-view></router-view>
  </div>
</template>

<script>
export default {
  data() {
    return {
      title: "Transfers",
      option1: "Create transfer",
      option2: "List transfers",
      option3: "Update transfer",
      option4: "Delete transfer"
    };
  },
};

</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
