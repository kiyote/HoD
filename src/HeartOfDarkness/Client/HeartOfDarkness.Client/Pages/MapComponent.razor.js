export function setRegion(
    areaId,
    style
) {
    var svg = document.getElementById("svgMap");
    var area = svg.getElementById(areaId);
    area.setAttribute("class", style);
}