<template>
  <div class="users">
    <p>{{title}}</p>

        <!-- Details  -->
    <p>
          <router-link to="/createuser">{{ option1 }}</router-link>
    </p>

    <p>
      <router-link to="/listusers">{{ option2 }}</router-link>
    </p>

    <p>
      <router-link to="/updateuser">{{ option3 }}</router-link>
    </p>

    <p>
      <router-link to="/deleteuser">{{ option4 }}</router-link>
    </p>
    
    
    <router-view></router-view>
  </div>
</template>

<script>
export default {
  data() {
    return {
      title: "Users",
      option1: "Create user",
      option2: "List users",
      option3: "Update user",
      option4: "Delete user"
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
