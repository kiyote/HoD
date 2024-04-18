export function setAreaStyle(
    areaId,
    style
) {
    console.log(`setAreaStyle(${areaId}, ${style})`);
    var svg = document.getElementById("svgMap");
    var area = svg.getElementById(areaId);
    area.setAttribute("class", style);
}