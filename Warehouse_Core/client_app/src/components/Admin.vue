<template>
  <div class="admin">
    <Navbar />

    <div id="content">
      <p>{{ title }}</p>

      <!-- Details  -->

      <p>
        <router-link to="/edituser" v-bind:likes="42" username="matt"
          >{{ option1 }}

          <EditUser v-bind:name="cameraNameeee" />
        </router-link>
      </p>

      <p>
        <router-link to="/roles" v-bind:likes="42">{{ option2 }}</router-link>
      </p>
    </div>
    <router-view></router-view>
  </div>
</template>

<script>
import EditUser from "./Admin/EditUser";
import Navbar from "./Navbar";

export default {
  name: "Admin",
  mounted() {},
  props: {
    name: {
      type: String,
      value: "admin-test",
    },
  },
  components: {
    EditUser,
    Navbar,
  },
  data() {
    return {
      title: "Admin",
      option1: "Edit user",
      option2: "Add role",
      likes1: this.likes,
    };
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped src="../assets/style/warehouse_style.css">
</style>
