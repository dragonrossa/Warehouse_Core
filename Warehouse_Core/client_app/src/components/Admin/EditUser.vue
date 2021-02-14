<template>
  <div class="admin">
    <div id="content">
    <p>{{ title }}</p>

    <!-- Details  -->
    <p>{{ name }}</p>
    </div>

    <router-view></router-view>
  </div>
</template>

<script>
export default {
  //  get filteredRestaurants(){
  //   return this.$attrs
  // },
  props: ["name"],
  data() {
    return {
      title: "Admin",
    };
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped src="../../assets/style/warehouse_style.css">
</style>