<template>
  <div class="admin">
    <Navbar />

    <div id="content">
      
      
      <p>{{ title }}</p>
      <!-- Details  -->

      <p>
        <router-link to="/edituser" v-bind:likes="42" username="matt"
          >{{ option1 }}

          <HelloWorld2 :name="cameraNameeee" />
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

import Navbar from "./Navbar";

import HelloWorld2 from "./Admin/EditUser"

export default {
 
  components: {
    Navbar,
    HelloWorld2
  },
  data() {
    return {
      title: "Admin",
      option1: "Edit user",
      option2: "Add role"
    };
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped src="../assets/style/warehouse_style.css">
</style>
