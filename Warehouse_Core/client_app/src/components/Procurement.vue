<template>
  <div class="procurement">
    <Navbar />
    <div id="content">
      <p>{{ title }}</p>

      <!-- Details  -->
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
      title: "Procurement",
    };
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped src="../assets/style/warehouse_style.css">
</style>
