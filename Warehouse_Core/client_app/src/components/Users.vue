<template>
  <div class="users">
    <Navbar />
    <div id="content">
      <p>{{ title }}</p>

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
    </div>
    <router-view></router-view>
  </div>
</template>

<script>
import Navbar from "./Navbar";

export default {
  components: {
    Navbar,
  },
  data() {
    return {
      title: "Users",
      option1: "Create user",
      option2: "List users",
      option3: "Update user",
      option4: "Delete user",
    };
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped src="../assets/style/warehouse_style.css">
</style>
