<template>
  <div class="suppliers">
    <p>{{title}}</p>

        <!-- Details  -->

             <p>
      <router-link to="/createsupplier">{{ option1 }}</router-link>
    </p>

    <p>
      <router-link to="/listsupplier">{{ option2 }}</router-link>
    </p>

    <p>
      <router-link to="/updatesupplier">{{ option3 }}</router-link>
    </p>

    <p>
      <router-link to="/deletesupplier">{{ option4 }}</router-link>
    </p>

    
    <router-view></router-view>
  </div>
</template>

<script>
export default {
  data() {
    return {
      title: "Suppliers",
      option1:"Create Supplier",
      option2:"List Supplier",
      option3: "Update Supplier",
      option4: "Delete Supplier"
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
