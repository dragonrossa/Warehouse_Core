<template>
  <div class="hello">
    <Navbar />
    <div id="content">
      <h1>{{ msg }}</h1>
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
  name: "HelloWorld",
  props: {
    msg: String,
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped src="../assets/style/warehouse_style.css">
</style>


