<template>
  <div class="storage">
    <p>{{title}}</p>

        <!-- Details  -->

         <p>
      <router-link to="/createitem">{{ option1 }}</router-link>
    </p>

    <p>
      <router-link to="/listitems">{{ option2 }}</router-link>
    </p>

    <p>
      <router-link to="/updateitem">{{ option3 }}</router-link>
    </p>

    <p>
      <router-link to="/deleteitem">{{ option4 }}</router-link>
    </p>

    
    <router-view></router-view>
  </div>
</template>

<script>
export default {
  data() {
    return {
      title: "Storage",
      option1:"Create item",
      option2:"List items",
      option3: "Update item",
      option4: "Delete item"
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
